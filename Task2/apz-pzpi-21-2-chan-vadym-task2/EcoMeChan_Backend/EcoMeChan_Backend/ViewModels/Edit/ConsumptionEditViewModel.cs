// ConsumptionEditViewModel.cs
using EcoMeChan.Enums;
using System;

namespace EcoMeChan.ViewModels.Edit
{
    public class ConsumptionEditViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TariffId { get; set; }
        public DateTime Date { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal ConsumedAmount { get; set; }
    }
}