using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            int counter = 10;
            
            while (counter > 0)
            {
                Console.WriteLine(randomNumber.Next(100, 200));
                counter--;
            }
            
            
        }
    }
}
