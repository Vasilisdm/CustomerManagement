using CustomerManagement;
using NUnit.Framework;
namespace CustomerManagementTests
{
    public class ProductRepositoryTests
    {
        [Test]
        public void ProductRetrieveTest()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product product = new Product()
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set for 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96M
            };

            // Act
            Product actualProduct = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(product.ProductName, actualProduct.ProductName);
            Assert.AreEqual(product.ProductDescription, actualProduct.ProductDescription);
            Assert.AreEqual(product.CurrentPrice, actualProduct.CurrentPrice);
        }
    }
}
