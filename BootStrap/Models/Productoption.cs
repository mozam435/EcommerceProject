using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class Productoption
    {
        public int ProductOptionId { get; set; }
        public int? OptionId { get; set; }
        public int? ProductId { get; set; }
        public int? OptionGroupId { get; set; }
        public decimal? OptionPriceIncrement { get; set; }
    }
}
