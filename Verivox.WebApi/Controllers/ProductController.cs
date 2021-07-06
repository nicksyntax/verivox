using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verivox.Business.Interfaces;
using Verivox.BusinessModels;

namespace Verivox.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("{consumption}")]
        public IList<ProductModel> CalculateConsumption(int consumption)
        {
            return _productService.CalculateConsumption(consumption);
        }

        [HttpGet]
        public IList<ProductModel> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }
    }
}
