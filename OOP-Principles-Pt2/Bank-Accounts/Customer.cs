namespace Bank_Accounts
{
    using System.Collections.Generic;
    using Interfaces;

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IList<IAccount> Accounts { get; set; }
        private readonly CustomerType customerType;

        public Customer(string firstName, string lastName,
                        int age, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.CustomerType = customerType;
            this.Accounts = new List<IAccount>();
        }

        public void AddAccount(IAccount account)
        {
            Accounts.Add(account);
        }

        public CustomerType CustomerType { get; private set; }
    }
}
