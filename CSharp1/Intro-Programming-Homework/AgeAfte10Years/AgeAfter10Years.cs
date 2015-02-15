using System;

namespace AgeAfte10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Please, type your birthday and press ENTER. Example: dd.mm.yyyy");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            long after10Years = DateTime.Today.Subtract(birthday).Ticks;
            Console.WriteLine("You are {0} years old.", new DateTime(after10Years).Year - 1);
            Console.WriteLine("After 10 years you will be {0} years old.", new DateTime(after10Years).AddYears(10).Year - 1);
        }
    }
}
