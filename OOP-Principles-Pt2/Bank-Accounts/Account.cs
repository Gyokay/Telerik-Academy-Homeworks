namespace Bank_Accounts
{
    using Interfaces;

    public abstract class Account : IAccount, IDepositable
    {
        public decimal Balance { get; protected  set; }
        public decimal InterestRate { get; set; }

        public Account(decimal interestRate)
        {
            this.Balance = 0.00M;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterestAmount(int months, CustomerType customer)
        {
            return months * InterestRate;
        }

        public void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
        }
    }
}
