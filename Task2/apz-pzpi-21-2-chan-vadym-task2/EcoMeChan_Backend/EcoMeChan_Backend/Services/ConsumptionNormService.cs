// ConsumptionNormService.cs


using EcoMeChan.Enums;
using EcoMeChan.Models;
using EcoMeChan.Repositories.Interfaces;
using EcoMeChan.Services.ConsumptionNorms;
using EcoMeChan_Backend.Services.ConsumptionNorms;
using System;
using System.Threading.Tasks;

namespace EcoMeChan.Services
{
    public class ConsumptionNormService : IConsumptionNormService
    {
        private readonly IConsumptionRepository _consumptionRepository;
        private readonly IConsumptionNormRepository _consumptionNormRepository;
        private readonly ConsumptionNormCalculator _consumptionNormCalculator;

        public ConsumptionNormService(IConsumptionRepository consumptionRepository, IConsumptionNormRepository consumptionNormRepository, ConsumptionNormCalculator consumptionNormCalculator)
        {
            _consumptionRepository = consumptionRepository;
            _consumptionNormRepository = consumptionNormRepository;
            _consumptionNormCalculator = consumptionNormCalculator;
        }

        public async Task CalculateConsumptionNormAsync(int userId, ResourceType resourceType, DateTime startDate, DateTime endDate)
        {
            var consumptionData = await _consumptionRepository.GetByUserIdAsync(userId, resourceType, startDate, endDate);

            if (consumptionData == null || !consumptionData.Any())
            {
                // Handle the case when there are no consumptions for the specified criteria
                throw new InvalidOperationException("No consumption data found for the specified criteria.");
            }

            var norm = _consumptionNormCalculator.CalculateNorm(consumptionData);

            var consumptionNorm = await _consumptionNormRepository.GetByUserIdAsync(userId, resourceType);
            if (consumptionNorm == null)
            {
                consumptionNorm = new ConsumptionNorm
                {
                    UserId = userId,
                    ResourceType = resourceType,
                    BaselineConsumption = norm.BaselineConsumption,
                    StandardDeviation = norm.StandardDeviation,
                    StartDate = startDate,
                    EndDate = endDate
                };

                await _consumptionNormRepository.CreateAsync(consumptionNorm);
            }
            else
            {
                consumptionNorm.BaselineConsumption = norm.BaselineConsumption;
                consumptionNorm.StandardDeviation = norm.StandardDeviation;
                consumptionNorm.StartDate = startDate;
                consumptionNorm.EndDate = endDate;

                await _consumptionNormRepository.UpdateAsync(consumptionNorm);
            }
        }

        public async Task<bool> DetectAnomaliesAsync(int userId, ResourceType resourceType, decimal currentConsumption)
        {
            var consumptionNorm = await _consumptionNormRepository.GetByUserIdAsync(userId, resourceType);
            if (consumptionNorm == null)
            {
                throw new InvalidOperationException("Consumption norm not found for the specified user and resource type.");
            }

            return _consumptionNormCalculator.IsAnomaly(currentConsumption, consumptionNorm.BaselineConsumption, consumptionNorm.StandardDeviation);
        }
    }
}