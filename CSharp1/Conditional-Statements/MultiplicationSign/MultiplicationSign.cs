/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());

            if ((a == 0 || b == 0 || c == 0))
            {
                Console.WriteLine("zero");
            }

            else if ((a > 0 && b > 0 && c > 0))
            {
                Console.WriteLine("positive");
            }

            else if (a < 0)
            {
                if ((b < 0 && c > 0) || (b > 0 && c < 0))
                {
                    Console.WriteLine("positive");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("negative");
                }
            }
            else if (a > 0)
            {
                if ((b < 0 && c > 0) || (b > 0 && c < 0))
                {
                    Console.WriteLine("negative");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}
