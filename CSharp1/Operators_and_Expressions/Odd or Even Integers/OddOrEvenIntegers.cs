/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
*/
using System;

namespace Odd_or_Even_Integers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please, type a number.");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) 
            Console.WriteLine("The nuber {0} is eaven", number);

            else
                Console.WriteLine("The number {0} is odd", number);
        }
    }
}
