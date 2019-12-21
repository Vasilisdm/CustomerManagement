using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer Retrieve(int customerId)
        {
            // Retrieve provided customer, needs implementation

            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            // Retrieve all customers, needs implementation

            return new List<Customer>();
        }

        public bool Save()
        {
            // Save customer, needs implementation

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }
    }
}
