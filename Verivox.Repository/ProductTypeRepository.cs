using Verivox.Entities;
using System.Collections.Generic;
using Verivox.Repository.Interfaces;
using System.Linq;

namespace Verivox.Repository
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        public bool Add(ProductType entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProductType Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductType> GetAll()
        {
            using (var context = new VerivoxContext())
            {
                return context.ProductTypes.ToList();
            }
        }

        public bool Update(ProductType entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
