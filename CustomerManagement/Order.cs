using System;
namespace CustomerManagement
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {

        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrieve(int orderId)
        {
            // Retrieve provided order, needs implementation

            return new Order();
        }

        public bool Save()
        {
            // save order, needs implementation

            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
