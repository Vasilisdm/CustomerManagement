using System;
namespace CustomerManagement
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {

        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            // Retrieve provided orderItemId, needs implementation

            return new OrderItem();
        }

        public bool Save()
        {
            // Save orderItem

            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (Quantity<=0) isValid = false;

            if (ProductId<=0) isValid = false;

            if (PurchasePrice<=0) isValid = false;

            return isValid;
        }
    }
}
