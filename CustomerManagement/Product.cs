using System;
namespace CustomerManagement
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            // Retrieve defined product, needs implementation

            return new Product();
        }

        public bool Save()
        {
            // Save product, needs implementation

            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;

            if (CurrentPrice == null)  isValid = false;

            return isValid;
        }
    }
}
