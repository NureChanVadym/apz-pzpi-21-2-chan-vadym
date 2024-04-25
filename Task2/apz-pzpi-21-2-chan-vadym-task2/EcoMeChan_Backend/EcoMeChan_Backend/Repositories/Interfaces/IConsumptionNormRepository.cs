// IConsumptionNormRepository.cs

using EcoMeChan.Enums;
using EcoMeChan.Models;
using System.Threading.Tasks;

namespace EcoMeChan.Repositories.Interfaces
{
    public interface IConsumptionNormRepository
    {
        Task<ConsumptionNorm> GetByUserIdAsync(int userId, ResourceType resourceType);
        Task<ConsumptionNorm> CreateAsync(ConsumptionNorm consumptionNorm);
        Task<ConsumptionNorm> UpdateAsync(ConsumptionNorm consumptionNorm);
    }
}