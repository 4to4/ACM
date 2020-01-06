using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }
        public string EmailAddress { get; private set; }
        public int CustomerId { get; private set; }
        public string FullName {
            get { return LastName + ", " + FirstName; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName;  }
            set { _lastName = value; }
        }

        public string FirstName { get; set; }

        public Customer()
        {
            InstanceCount++;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }



    }
}
