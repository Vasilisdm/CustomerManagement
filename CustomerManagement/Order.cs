using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Order : EntityBase
    {
        public Order():this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }
        public int CustomerId { get; set; }
        public int ShippingAddress { get; set; }
        public List<OrderItem> OrderItems{ get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public override bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
