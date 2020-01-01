using System;
using CustomerManagement;
using NUnit.Framework;

namespace CustomerManagementTests
{
    public class OrderRepositoryTests
    {
        [Test]
        public void OrderRetrieveTest()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order order = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 12, 31, 14, 45, 40, new TimeSpan(5, 0, 0))
            };

            // Act
            var actualOrder = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(order.OrderDate, actualOrder.OrderDate);
        }

        [Test]
        public void SaveTestValid()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order order = new Order()
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 12, 31, 14, 45, 40, new TimeSpan(5, 0, 0)),
                HasChanges = true
            };

            // Act
            var isOrderSaved = orderRepository.Save(order);

            // Assert
            Assert.AreEqual(true, isOrderSaved);
        }

        [Test]
        public void OrderDateMissing()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order order = new Order()
            {
                OrderDate = null,
                HasChanges = true
            };

            // Act
            var isOrderSaved = orderRepository.Save(order);

            // Assert
            Assert.AreEqual(false, isOrderSaved);
        }
    }
}
