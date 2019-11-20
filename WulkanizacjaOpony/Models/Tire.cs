using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WulkanizacjaOpony.Models
{
    public class Tire
    {
        public int TireId { get; set; }
        public TireSeason Season { get; set; }
        public int Width { get; set; }
        public int Profile { get; set; }
        public int Diameter { get; set; }
        public string Company { get; set; }
        public TireState State { get; set; }
        public int ProductionYear { get; set; }
        public string Model { get; set; }
        public string ProducentCode { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageFileName { get; set; }
        public bool IsHidden { get; set; }
    }

    public enum TireSeason
    {
        [Description("Winter")]
        Winter = 1,
        [Description("Summer")]
        Summer = 2,
        [Description("All-Season")]
        AllSeason = 3
    }

    public enum TireState
    {
        [Description("New")]
        New = 1,
        [Description("Used")]
        Used = 2
    }
}