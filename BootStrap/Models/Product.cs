using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public double? ProductWeight { get; set; }
        public string ProductCartDiscount { get; set; }
        public string ProductShortDiscription { get; set; }
        public string ProductLongDiscription { get; set; }
        public string ProductThumb { get; set; }
        public int? ProductCategoryId { get; set; }
        public byte[] ProductUpdateDate { get; set; }
        public double? ProductStock { get; set; }
        public string ProductLive { get; set; }
        public string ProductUnlimited { get; set; }
        public string ProductLocation { get; set; }
        public string ProductImage { get; set; }
    }
}
