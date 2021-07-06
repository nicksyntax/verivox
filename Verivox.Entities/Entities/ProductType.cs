using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verivox.Entities
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
