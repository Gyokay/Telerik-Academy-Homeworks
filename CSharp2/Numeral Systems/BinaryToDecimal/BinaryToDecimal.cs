using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            //Console.WriteLine(Convert.ToInt32("101", 2).ToString());
            int binNumber =int.Parse(Console.ReadLine());
            double result = 0;
            int index = 0;
            while (binNumber > 0)
            {
                
                int digit = binNumber % 10;
                binNumber /= 10;
                result += digit * Math.Pow(2, index);
                index++;
            }
            Console.WriteLine(result);
        }
    }
}
