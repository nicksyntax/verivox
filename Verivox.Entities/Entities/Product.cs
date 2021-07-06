using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verivox.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int MonthlyBaseValue { get; set; }
        public int Cost { get; set; }
        public int ConsumptionThreshold { get; set; }
        public int AdditionalCostPerKwh { get; set; }
        
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }


    }
}
