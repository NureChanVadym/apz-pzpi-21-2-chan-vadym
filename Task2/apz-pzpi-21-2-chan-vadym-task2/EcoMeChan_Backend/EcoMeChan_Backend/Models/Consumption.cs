// Consumption.cs


using EcoMeChan.Enums;

namespace EcoMeChan.Models
{
    public class Consumption
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TariffId { get; set; }
        public DateTime Date { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal ConsumedAmount { get; set; }
        public decimal ConsumedCost { get; set; }

        public User User { get; set; }
        public Tariff Tariff { get; set; }
    }
}