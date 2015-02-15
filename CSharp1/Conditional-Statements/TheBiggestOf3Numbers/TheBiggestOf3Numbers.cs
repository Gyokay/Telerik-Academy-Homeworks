/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());

            if (a == b && a == c)
            {
                Console.WriteLine("eqal");
            }

            else if ((a >= b && c < a) || (a >= c && b < c))
            {
                Console.WriteLine("The biggest number is {0}:", a);                
            }

            else if ((b >= a && c < b) || (b >= c && a < b))
            {
                Console.WriteLine("The biggest number is {0}:", b);
            }

            else if ((c >= a && b < c) || (c >= b && a < c))
            {
                Console.WriteLine("The biggest number is {0}:", c);
            }

           
        }
    }
}
