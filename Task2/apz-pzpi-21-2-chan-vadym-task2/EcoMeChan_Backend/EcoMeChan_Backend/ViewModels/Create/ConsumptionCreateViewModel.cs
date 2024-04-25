// ConsumptionCreateViewModel.cs
using EcoMeChan.Enums;
using System;

namespace EcoMeChan.ViewModels.Create
{
    public class ConsumptionCreateViewModel
    {
        public int UserId { get; set; }
        public int TariffId { get; set; }
        public DateTime Date { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal ConsumedAmount { get; set; }
    }
}