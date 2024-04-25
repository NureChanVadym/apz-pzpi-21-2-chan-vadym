// Tariff.cs

using EcoMeChan.Enums;

namespace EcoMeChan.Models
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Consumption> Consumptions { get; set; }
    }
}