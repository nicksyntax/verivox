using System;
using Verivox.Entities;
using System.Collections.Generic;
using Verivox.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Verivox.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool Add(Product entity)
        {
            using (var context = new VerivoxContext())
            {
                context.Products.Add(entity);
                int noOfentitesWritten = context.SaveChanges();
                return noOfentitesWritten > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new VerivoxContext())
            {
                Product product = new Product{ ProductId = id };
                context.Entry(product).State = EntityState.Deleted;
                int noOfentitesWritten = context.SaveChanges();
                return noOfentitesWritten > 0;
            }
        }

        public Product Get(int id)
        {
            using (var context = new VerivoxContext())
            {
                return context.Products.Where(p => p.ProductId == id).Include(p => p.ProductType).FirstOrDefault();
            }
        }

        public List<Product> GetAll()
        {
            using (var context = new VerivoxContext())
            {
                return context.Products.Include(p=>p.ProductType).ToList();
            }
        }

        public bool Update(Product entity)
        {
            using (var context = new VerivoxContext())
            {
                context.Products.Update(entity);
                int noOfentitesWriiten = context.SaveChanges();
                return noOfentitesWriiten > 0;
            }
        }
    }
}
