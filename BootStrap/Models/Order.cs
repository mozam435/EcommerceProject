using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? OrderUserId { get; set; }
        public double? OrderAmount { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipAddress2 { get; set; }
        public string OrderQty { get; set; }
        public string OrderState { get; set; }
        public string OrderZip { get; set; }
        public string OrderCountry { get; set; }
        public string OrderPhone { get; set; }
        public string OrderFax { get; set; }
        public double? OrderShipping { get; set; }
        public double? OrderTax { get; set; }
        public string OrderEmail { get; set; }
        public byte[] OrderDate { get; set; }
        public byte? OrderShipped { get; set; }
        public string OrderTrackingNumber { get; set; }
    }
}
