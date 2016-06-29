namespace Bank_Accounts
{
    using System.Collections;
    using System.Collections.Generic;

    public class Bank
    {
        private IList<Customer> customers;

        public Bank()
        {
            this.Customers = new List<Customer>();
        }

        public IList<Customer> Customers
        {
            get
            {
                return this.customers;
            }

            private set
            {
                this.customers = value;
            }
        }

        public void AddNewCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
