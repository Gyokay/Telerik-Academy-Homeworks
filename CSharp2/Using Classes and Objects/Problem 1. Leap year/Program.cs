using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            
            bool isLeapYear = System.DateTime.IsLeapYear(year);
            Console.WriteLine(isLeapYear);
        }
    }
}
