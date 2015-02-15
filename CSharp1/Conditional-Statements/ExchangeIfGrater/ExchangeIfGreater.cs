//Problem 1. Exchange If Greater
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGrater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }

            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
