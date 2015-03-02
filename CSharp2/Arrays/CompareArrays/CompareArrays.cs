/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
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
            
            //string input1 = Console.ReadLine();
            
            //string input2 = Console.ReadLine();

            //string[] array1 = input1.Split(',', ' ');
            //string[] array2 = input2.Split(',', ' ');

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        int current1 = int.Parse(array1[i]);
            //        int current2 = int.Parse(array2[i]);
            //        if (current1 < current2)
            //        {
            //            Console.WriteLine(current1 + " < " + current2);
            //        }
            //        else if (current1 > current2)
            //        {
            //            Console.WriteLine(current1 + " > " + current2);
            //        }
            //        else if (current1 == current2)
            //        {
            //            Console.WriteLine("they are equal");
            //        }
            //    }
            //}
            int arrLength1 = int.Parse(Console.ReadLine());
            int arrLength2 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arrLength1];
            int[] arr2 = new int[arrLength2];

            for (int i = 0; i < arrLength1; i++)
			{
                arr1[i] = int.Parse(Console.ReadLine());
			}
            for (int i = 0; i < arrLength1; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            
            
            
            
            for (int i = 0; i < arrLength1; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("{0} is bigger than {1}", arr1[i], arr2[i]);
                }
                else if(arr1[i] == arr2[i])
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("{0} is smaller than {1}", arr1[i], arr2[i]);
                }
            }

        }
    }
}//3
 //3
 //3
 //2
 //3
 //1
 //2
 //4