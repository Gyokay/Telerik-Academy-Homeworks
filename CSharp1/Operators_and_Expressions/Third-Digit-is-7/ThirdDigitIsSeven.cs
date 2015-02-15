/*
Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Digit_is_7
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, type a number.");
            int number = int.Parse(Console.ReadLine());
            int findnumber = (number / 100) % 10;
            bool ifSeven = findnumber == 7;
            Console.WriteLine("The third digit is 7: {0}", ifSeven);


        }
    }
}
