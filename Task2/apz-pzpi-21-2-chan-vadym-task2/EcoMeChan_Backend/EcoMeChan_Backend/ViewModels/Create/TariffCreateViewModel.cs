// TariffCreateViewModel.cs
using EcoMeChan.Enums;
using System;

namespace EcoMeChan.ViewModels.Create
{
    public class TariffCreateViewModel
    {
        public string Name { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}