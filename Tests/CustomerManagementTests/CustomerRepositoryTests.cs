using CustomerManagement;
using NUnit.Framework;

namespace CustomerManagementTests
{
    public class CustomerRepositoryTests
    {
        [Test]
        public void RetrieveValid()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository();
            Customer customer = new Customer(1)
            {
                Email = "Baggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            Customer actualCustomer = customerRepo.Retrieve(1);

            // Assert
            Assert.AreEqual(customer.Email, actualCustomer.Email);
            Assert.AreEqual(customer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(customer.LastName, actualCustomer.LastName);
        }
    }
}
