using System;

namespace CustomerManagement
{
    public class Customer
    {
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
