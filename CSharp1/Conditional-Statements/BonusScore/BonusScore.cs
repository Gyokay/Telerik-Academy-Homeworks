//Problem 2. Bonus Score
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("score:");
            int s = int.Parse(Console.ReadLine());

         if ( s <= 3 )
         {
             Console.WriteLine(s * 10);
         }
         
         else if (s >= 4 && s <= 6 )
            {
                Console.WriteLine(s * 100);
            }

         else if (s >= 7 && s <= 9)
         {
             Console.WriteLine(s * 1000);
         }

         else
         {
             Console.WriteLine("Invalid score");
         }
        
        }
    }
}
