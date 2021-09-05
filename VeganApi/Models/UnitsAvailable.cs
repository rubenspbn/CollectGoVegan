using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganApi.Models
{
    public class UnitsAvailable
    {
        public Guid ProductId { get; set; }
        public Guid StoreId { get; set; }
        public int UnitInStock { get; set; }
    }
}
