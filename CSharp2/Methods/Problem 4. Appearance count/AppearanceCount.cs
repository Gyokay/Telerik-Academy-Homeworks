using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Appearance_count
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 4, 2, 1, 2 };
            //int number = 2;
            //int counter = CountGivenNumber(2, 2, 4, 2, 1, 2); //(number, arr);

            Console.WriteLine(CountGivenNumber(2, 2, 4, 2, 1, 2)); //(counter);
        }

        static int CountGivenNumber(int number, params int[] arr)
        {
            int counter = 0;
            foreach (int item in arr)
            {
                if (item == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
