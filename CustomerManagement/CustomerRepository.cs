using System;
using System.Linq;

namespace CustomerManagement
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            // Dummy retrieve
            Customer customer = new Customer(customerId);

            if (customerId==1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.Email = "Baggins@gmail.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // Dummy save method
            return true;
        }
    }
}
