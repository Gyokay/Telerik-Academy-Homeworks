/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1213
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = { 'a', 'g', 'p', 's', 'e', 'p' };
            char[] arr2 = { 'a', 'u', 'q', 'x', 'e', 'o' };
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(arr1[i] + " is before " + arr2[i]);
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(arr1[i] + " is after " + arr2[i]);
                }
                else
                {
                    Console.WriteLine(arr1[i] + " is the same as " + arr2[i]);
                }
            }
        }
    }
}