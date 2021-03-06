using CustomerManagement;
using NUnit.Framework;

namespace CustomerManagementTests
{
    public class CustomerTests
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

        [Test]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer()
            {
                LastName = "Doe",
                Email = "JDoe@gmail.com"
            };

            bool expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer()
            {
                Email = "JDoe@gmail.com"
            };

            bool expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingEmail()
        {
            // Arrange
            Customer customer = new Customer()
            {
                LastName = "Doe"
            };

            bool expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}