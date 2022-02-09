using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class Orderdetail
    {
        public int OrderId { get; set; }
        public int? DetailOrderId { get; set; }
        public int? DetailProductId { get; set; }
        public string DetailName { get; set; }
        public double? DetailPrice { get; set; }
        public string DetailSku { get; set; }
        public int? DetailQty { get; set; }
    }
}
