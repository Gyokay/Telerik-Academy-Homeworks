namespace Client
{
    using System;
    using Shapes;
    using Bank_Accounts;
    using Bank_Accounts.Accounts;
    using RangeException;

    class Startup
    {
        static void Main(string[] args)
        {
            //Test Shapes
            var shapesArr = new object[3];
            shapesArr[0] = new Square(5.2D);
            shapesArr[1] = new Rectange(5.2D, 8.5D);
            shapesArr[2] = new Triangle(6.66D, 10D);

            Console.WriteLine(new string('-', 35));
            Console.WriteLine("Calculate the surface of the shapes");
            Console.WriteLine(shapesArr[0].ToString());
            Console.WriteLine(shapesArr[1].ToString());
            Console.WriteLine(shapesArr[2].ToString());
            Console.WriteLine(new string('-', 35));
            Console.WriteLine();

            //Test Bank Accounts
            var bank = new Bank();
            bank.AddNewCustomer(new Customer("Ivan", "Ivanov", 26, CustomerType.individual));
            bank.Customers[0].AddAccount(new Deposit(1.5M));

            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Interest rate of {bank.Customers[0].FirstName} {bank.Customers[0].LastName} is:");
            Console.WriteLine(bank.Customers[0].Accounts[0].CalculateInterestAmount(3, CustomerType.individual));
            Console.WriteLine(new string('-', 35));
            Console.WriteLine();

            //Test Range Exceptions
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("Testing Range Exceptions");
            Console.WriteLine();

            try
            {
                throw new InvalidRangeException<int>("Invalid elements!", 1, 100);
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
            }

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date parameters!", new DateTime(1980, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
            }
            Console.WriteLine(new string('-', 35));
            Console.WriteLine();
        }
    }
}
