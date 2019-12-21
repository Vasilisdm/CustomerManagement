using System;
namespace CustomerManagement
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Dummy product retrieve
            Product product = new Product(productId);

            if (productId==2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set for 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            // Dummy product store.

            return true;
        }
    }
}
