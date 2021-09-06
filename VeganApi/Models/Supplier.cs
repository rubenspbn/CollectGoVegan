using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganApi.Models
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLocation { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
