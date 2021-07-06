using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verivox.BusinessModels
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int MonthlyBaseValue { get; set; }
        public int Cost { get; set; }
        public int ConsumptionThreshold { get; set; }
        public int AdditionalCostPerKwh { get; set; }
        public decimal AnnualCost { get; set; }
        
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
    }
}
