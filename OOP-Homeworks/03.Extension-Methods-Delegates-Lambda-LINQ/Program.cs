using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new StringBuilder();
            foo.Append("Problem 1. StringBuilder.Substring");

            var bar = foo.Substring(0, 3);

            string fomeString = "some string";
            string someNewString = "some new string";

            var sum = someNewString.Sum();

            Console.WriteLine(sum);
        }
    }
}
