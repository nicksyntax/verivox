using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.BusinessModels;

namespace Verivox.Business.Interfaces
{
    public interface IProductService
    {
        public bool CreateProduct(ProductModel productModel);
        public bool UpdateProduct(ProductModel productModel);
        public bool DeleteProduct(int id);
        public IList<ProductModel> GetAllProducts();
        public ProductModel GetProductById(int id);
        public IList<ProductModel> CalculateConsumption(int consumption);
    }
}
