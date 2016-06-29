namespace Bank_Accounts.Interfaces
{
    public interface IAccount
    {
        decimal Balance { get; }
        decimal InterestRate { get; set; }

        decimal CalculateInterestAmount(int months, CustomerType customer);
    }
} 
