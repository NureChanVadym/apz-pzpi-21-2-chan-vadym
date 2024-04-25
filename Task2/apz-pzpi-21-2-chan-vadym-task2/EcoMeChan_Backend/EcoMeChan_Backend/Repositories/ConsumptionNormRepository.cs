// ConsumptionNormRepository.cs
using EcoMeChan.Database;
using EcoMeChan.Enums;
using EcoMeChan.Models;
using EcoMeChan.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcoMeChan.Repositories
{
    public class ConsumptionNormRepository : IConsumptionNormRepository
    {
        private readonly ApplicationDbContext _context;

        public ConsumptionNormRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ConsumptionNorm> GetByUserIdAsync(int userId, ResourceType resourceType)
        {
            return await _context.ConsumptionNorms
                .FirstOrDefaultAsync(cn => cn.UserId == userId && cn.ResourceType == resourceType);
        }

        public async Task<ConsumptionNorm> CreateAsync(ConsumptionNorm consumptionNorm)
        {
            _context.ConsumptionNorms.Add(consumptionNorm);
            await _context.SaveChangesAsync();
            return consumptionNorm;
        }

        public async Task<ConsumptionNorm> UpdateAsync(ConsumptionNorm consumptionNorm)
        {
            _context.ConsumptionNorms.Update(consumptionNorm);
            await _context.SaveChangesAsync();
            return consumptionNorm;
        }
    }
}