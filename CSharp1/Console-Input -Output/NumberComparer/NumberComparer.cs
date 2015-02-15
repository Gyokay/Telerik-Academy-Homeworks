using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, pype args number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, pype args number.");
            int b = int.Parse(Console.ReadLine());
            int greater = a>b ? a:b;
            Console.WriteLine(greater);
        }
    }
}
