namespace Bank_Accounts.Accounts
{
    using System;

    public class Mortgage : Account
    {
        public Mortgage(decimal interstRate)
            : base(interstRate)
        {

        }

        public override decimal CalculateInterestAmount(int months, CustomerType customer) {
            if(months <= 12 && customer == CustomerType.company)
            {
                return (months * InterestRate) / 2;
            }
            else if (months <= 6 && customer == CustomerType.company)
            {
                throw new ApplicationException("No interest for the first 6 months!");
            }

            return months * InterestRate;
        }
    }
}
