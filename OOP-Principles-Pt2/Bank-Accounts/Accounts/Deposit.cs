namespace Bank_Accounts.Accounts
{
    using System;
    using Interfaces;

    public class Deposit : Account, IWithdrawable
    {
        public Deposit(decimal interestRate)
            : base(interestRate)
        {
            
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int months, CustomerType customer)
        {
            if (Balance > 0 && Balance < 1000.00m)
            {
                throw new ApplicationException("Deposit accounts have no interest because balance is positive and less than 1000.");
            }

            return months * InterestRate;
        }
    }
}
