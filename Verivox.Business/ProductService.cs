using System;
using System.Linq;
using System.Collections.Generic;
using Verivox.Business.Interfaces;
using Verivox.BusinessModels;
using Verivox.Repository.Interfaces;

namespace Verivox.Business
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IList<ProductModel> CalculateConsumption(int consumption)
        {
            List<ProductModel> products = new List<ProductModel>();
            List<Entities.Product> productEntities = _productRepository.GetAll();
            productEntities.ForEach(prod => {
                ProductModel productModel = new ProductModel() { };
                productModel.ProductId = prod.ProductId;
                productModel.ProductName = prod.ProductName;
                productModel.ProductTypeId = prod.ProductTypeId;
                productModel.ProductTypeName = prod.ProductType.ProductTypeName;
                productModel.MonthlyBaseValue = prod.MonthlyBaseValue;
                productModel.Cost = prod.Cost;
                productModel.ConsumptionThreshold = prod.ConsumptionThreshold;
                productModel.AdditionalCostPerKwh = prod.AdditionalCostPerKwh;

                switch (productModel.ProductTypeId)
                {
                    case Constants.ProductType.baseCostBased:
                        productModel.AnnualCost = (productModel.MonthlyBaseValue * 12) + ((decimal)productModel.Cost * consumption)/100;
                        break;
                    case Constants.ProductType.thresholdBased:
                        productModel.AnnualCost = consumption <= productModel.ConsumptionThreshold ? productModel.Cost : productModel.Cost + (((consumption - productModel.ConsumptionThreshold) * (decimal)productModel.AdditionalCostPerKwh) / 100);
                        break;
                }
                
                products.Add(productModel);
            });
            return products.OrderBy(p=>p.AnnualCost).ToList();
        }

        public bool CreateProduct(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProductModel> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            List<Entities.Product> productEntities = _productRepository.GetAll();
            productEntities.ForEach(prod => {
                ProductModel productModel = new ProductModel() { };
                productModel.ProductId = prod.ProductId;
                productModel.ProductName = prod.ProductName;
                productModel.ProductTypeId = prod.ProductTypeId;
                productModel.ProductTypeName = prod.ProductType.ProductTypeName;
                productModel.MonthlyBaseValue = prod.MonthlyBaseValue;
                productModel.Cost = prod.Cost;
                productModel.ConsumptionThreshold = prod.ConsumptionThreshold;
                productModel.AdditionalCostPerKwh = prod.AdditionalCostPerKwh;

                products.Add(productModel);
            });
            return products;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(ProductModel productModel)
        {
            throw new NotImplementedException();
        }
    }
}
