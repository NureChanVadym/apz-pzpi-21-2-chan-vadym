// ConsumptionNormController.cs

using EcoMeChan.Enums;
using EcoMeChan_Backend.Services.ConsumptionNorms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EcoMeChan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsumptionNormController : ControllerBase
    {
        private readonly IConsumptionNormService _consumptionNormService;

        public ConsumptionNormController(IConsumptionNormService consumptionNormService)
        {
            _consumptionNormService = consumptionNormService;
        }

        [HttpPost("calculate")]
        public async Task<IActionResult> CalculateConsumptionNorm(int userId, ResourceType resourceType, DateTime startDate, DateTime endDate)
        {
            await _consumptionNormService.CalculateConsumptionNormAsync(userId, resourceType, startDate, endDate);
            return Ok();
        }

        [HttpGet("detect-anomalies")]
        public async Task<IActionResult> DetectAnomalies(int userId, ResourceType resourceType, decimal currentConsumption)
        {
            var isAnomaly = await _consumptionNormService.DetectAnomaliesAsync(userId, resourceType, currentConsumption);
            return Ok(new { IsAnomaly = isAnomaly });
        }
    }
}