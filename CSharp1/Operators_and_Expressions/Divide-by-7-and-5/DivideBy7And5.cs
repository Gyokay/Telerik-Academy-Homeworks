/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/
using System;

namespace Divide_by_7_and_5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Please, type a number.");
            int a = int.Parse(Console.ReadLine());
            if (a % 5 == 0 && a % 7 == 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
