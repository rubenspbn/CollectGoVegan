using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
