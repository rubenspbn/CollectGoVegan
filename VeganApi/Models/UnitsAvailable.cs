using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeganApi.Models
{
    public class UnitsAvailable
    {
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        [ForeignKey(nameof(Store))]
        public Guid StoreId { get; set; }
        public int UnitInStock { get; set; }
    }
}
