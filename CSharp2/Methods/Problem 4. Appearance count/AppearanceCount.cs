/*Problem 4. Appearance count
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

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
            //int counter = CountGivenNumber(number, arr);
            //Console.WriteLine(counter);

            Console.WriteLine(CountGivenNumber(2, 2, 4, 2, 1, 2));
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
