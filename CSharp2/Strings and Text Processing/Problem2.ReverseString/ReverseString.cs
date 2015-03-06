using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputString = "dog";
            char[] charArr = inputString.ToCharArray();
            Array.Reverse(charArr);
            Console.WriteLine(charArr);
        }
    }
}
