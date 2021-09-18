using System;

namespace VeganApi.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public string ProductDescription { get; set; }
        public Guid SupplierId { get; set; }
        public string Brand { get; set; }
    }
}
