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

            string excpectedFullName = "Frodo Baggins";

            // Act
            string actualFullName = customer.FullName;

            // Assert
            Assert.AreEqual(excpectedFullName, actualFullName);
        }
    }
}