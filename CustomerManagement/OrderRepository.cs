using System;
namespace CustomerManagement
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId==10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 12, 31, 14, 45, 40, new TimeSpan(5, 0, 0));
            }

            return order;
        }


        public bool Save()
        {
            // dummy order save

            return true;
        } 
    }
}
