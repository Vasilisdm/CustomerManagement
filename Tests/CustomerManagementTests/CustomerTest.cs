using CustomerManagement;
using NUnit.Framework;

namespace CustomerManagementTests
{
    public class CustomerTest
    {
        [Test]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            string excpectedFullName = "Baggins, Frodo";

            // Act
            string actualFullName = customer.FullName;

            // Assert
            Assert.AreEqual(excpectedFullName, actualFullName);
        }

        [Test]
        public void FullNameTestEmptyFirstName()
        {
            // Arrange
            Customer customer = new Customer()
            {
                LastName = "Baggins"
            };

            string excpectedFullName = "Baggins";

            // Act
            string actualFullName = customer.FullName;

            // Assert
            Assert.AreEqual(excpectedFullName, actualFullName);
        }

        [Test]
        public void FullNameTestEmptyLastName()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Frodo"
            };

            string excpectedFullName = "Frodo";

            // Act
            string actualFullName = customer.FullName;

            // Assert
            Assert.AreEqual(excpectedFullName, actualFullName);
        }
    }
}