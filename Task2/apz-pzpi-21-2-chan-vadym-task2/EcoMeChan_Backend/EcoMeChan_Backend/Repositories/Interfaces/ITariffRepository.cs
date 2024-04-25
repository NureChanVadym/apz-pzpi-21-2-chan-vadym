// ITariffRepository.cs


using EcoMeChan.Models;
using EcoMeChan.Enums;

namespace EcoMeChan.Repositories.Interfaces
{
    public interface ITariffRepository
    {
        Task<Tariff> CreateAsync(Tariff tariff);
        Task<Tariff> GetAsync(int tariffId);
        Task<IEnumerable<Tariff>> GetAllAsync();
        Task<IEnumerable<Tariff>> GetByResourceTypeAsync(ResourceType resourceType);
        Task<Tariff> GetByResourceTypeAndDateAsync(ResourceType resourceType, DateTime date);
        Task<Tariff> UpdateAsync(Tariff tariff);
        Task DeleteAsync(int tariffId);
    }
}