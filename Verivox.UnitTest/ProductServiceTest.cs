using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Verivox.UnitTest
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void TestCalculateConsumption()
        {
            Business.ProductService productService = new Business.ProductService(new Repository.ProductRepository());
            var prod = productService.CalculateConsumption(3500);
        }
    }
}
