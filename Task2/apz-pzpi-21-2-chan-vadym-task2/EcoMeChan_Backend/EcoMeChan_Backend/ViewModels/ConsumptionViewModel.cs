﻿// ConsumptionViewModel.cs
using EcoMeChan.Enums;
using System;

namespace EcoMeChan.ViewModels
{
    public class ConsumptionViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TariffId { get; set; }
        public DateTime Date { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal ConsumedAmount { get; set; }
        public decimal ConsumedCost { get; set; }
    }
}