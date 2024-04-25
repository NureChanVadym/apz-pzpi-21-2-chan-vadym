// IConsumptionNormService.cs


using EcoMeChan.Enums;
using System;
using System.Threading.Tasks;

namespace EcoMeChan_Backend.Services.ConsumptionNorms
{
    
    public interface IConsumptionNormService
    {
        // template method
        Task CalculateConsumptionNormAsync(int userId, ResourceType resourceType, DateTime startDate, DateTime endDate);
        Task<bool> DetectAnomaliesAsync(int userId, ResourceType resourceType, decimal currentConsumption);
    }
}