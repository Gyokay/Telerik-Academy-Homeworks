namespace Bank_Accounts.Accounts
{
    using System;

    public class Loan : Account
    {
        public Loan(decimal interestRate)
            : base(interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int months, CustomerType customer)
        {
            if(months <= 3 && customer == CustomerType.individual)
            {
                throw new ApplicationException("Loan accounts have no interest for the first 3 months");
            }
            else if (months <= 2 && customer == CustomerType.company)
            {
                throw new ApplicationException("Loan accounts have no interest for the first 2 months");
            }

            return months * InterestRate;
        }
    }
}
