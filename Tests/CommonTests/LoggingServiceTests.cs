using System;
using System.Collections.Generic;
using Common;
using CustomerManagement;
using NUnit.Framework;

namespace CommonTests
{
    public class LoggingServiceTests
    {
        [Test]
        public void WriteToFileTest()
        {
            // Arrange
            List<ILoggable> changedItems = new List<ILoggable>();
            
            Customer customer = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            Product product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with steel head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
        }

    }
}
