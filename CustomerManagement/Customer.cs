using System;

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


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
