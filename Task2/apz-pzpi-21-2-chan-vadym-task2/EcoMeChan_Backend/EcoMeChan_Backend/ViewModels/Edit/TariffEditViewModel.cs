﻿// TariffEditViewModel.cs
using EcoMeChan.Enums;
using System;

namespace EcoMeChan.ViewModels.Edit
{
    public class TariffEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ResourceType ResourceType { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}