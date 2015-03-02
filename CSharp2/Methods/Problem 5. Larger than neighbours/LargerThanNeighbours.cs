using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Larger_than_neighbours
{
    class Program
    {
            static void Main(string[] args)
        {
            int[] arr = new int[4] { 1, 2, 4, 3 };
            int index = 3;

            Console.WriteLine(LargerThanTheNaightours(arr, index));
            

        }
        
        static bool LargerThanTheNaightours(int[] arr, int index)
        {
            bool isLarger = false;
            if (index == 0)
            {
                isLarger = arr[index] > arr[index + 1];
            }
            else if (index == arr.Length)
            {
                isLarger = arr[index] > arr[index - 1];
            }
            else
            {
                isLarger = (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]);
            }
            return isLarger;
        }
        
    }
}
