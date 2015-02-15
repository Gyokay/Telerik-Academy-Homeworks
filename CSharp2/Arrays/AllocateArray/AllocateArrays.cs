/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class AllocateArrays
    {
        static void Main(string[] args)
        {
            int number = 20;
            int[] array = new int [number];
            for (int i = 0; i < array.Length; i++)
			{
                Console.WriteLine(array[i] = i * 5);
			}

        }
    }
}
