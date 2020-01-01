using System.Collections.Generic;
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

        [Test]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer customer = new Customer(1)
            {
                Email = "Baggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            // Act
            Customer actualCustomer = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(customer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(customer.Email, actualCustomer.Email);
            Assert.AreEqual(customer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(customer.LastName, actualCustomer.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(customer.AddressList[i].AddressType, actualCustomer.AddressList[i].AddressType);
                Assert.AreEqual(customer.AddressList[i].StreetLine1, actualCustomer.AddressList[i].StreetLine1);
                Assert.AreEqual(customer.AddressList[i].StreetLine2, actualCustomer.AddressList[i].StreetLine2);
                Assert.AreEqual(customer.AddressList[i].City, actualCustomer.AddressList[i].City);
                Assert.AreEqual(customer.AddressList[i].State, actualCustomer.AddressList[i].State);
                Assert.AreEqual(customer.AddressList[i].Country, actualCustomer.AddressList[i].Country);
                Assert.AreEqual(customer.AddressList[i].PostalCode, actualCustomer.AddressList[i].PostalCode);
            }
        }

        [Test]
        public void SaveTestValid()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository();
            Customer customer = new Customer()
            {
                Email = "Baggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                HasChanges = true
            };

            // Act
            bool isCustomerSaved = customerRepo.Save(customer);

            // Assert
            Assert.AreEqual(true, isCustomerSaved);
        }

        [Test]
        public void CustomerMissingEmail()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository();
            Customer customer = new Customer()
            {
                Email = null,
                FirstName = "Frodo",
                LastName = "Baggins",
                HasChanges = true
            };

            // Act
            bool isCustomerSaved = customerRepo.Save(customer);

            // Assert
            Assert.AreEqual(false, isCustomerSaved);
        }

        [Test]
        public void CustomerMissingLastName()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository();
            Customer customer = new Customer()
            {
                Email = "Baggins@gmail.com",
                FirstName = "Frodo",
                LastName = null,
                HasChanges = true
            };

            // Act
            bool isCustomerSaved = customerRepo.Save(customer);

            // Assert
            Assert.AreEqual(false, isCustomerSaved);
        }
    }
}
