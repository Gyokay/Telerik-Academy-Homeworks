/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            float max = float.MinValue;
            float min = float.MaxValue;
            float sum = 0;
            float avg = 0;

            float n = float.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                float current = float.Parse(Console.ReadLine());
                max = Math.Max(max, current);
                min = Math.Min(min, current);
                sum += current;
            }
            avg = sum / n;

            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avg = {0:F2}", avg);
        }
    }
}
