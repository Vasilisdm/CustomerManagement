using System;
namespace CustomerManagement
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Dummy retrieve
            Customer customer = new Customer(customerId);

            if (customerId==1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.Email = "Baggins@gmail.com";
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
