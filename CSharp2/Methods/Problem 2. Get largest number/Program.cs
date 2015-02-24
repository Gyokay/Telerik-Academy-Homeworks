using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Get_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numOne = int.Parse(Console.ReadLine());
            //int numTwo = int.Parse(Console.ReadLine());
            //int numThree = int.Parse(Console.ReadLine());

            //int biggestFromTheThree = GetMax(numOne, numTwo);
            //if (biggestFromTheThree >= numThree)
            //{
            //    Console.WriteLine("The biggest number is {0}", biggestFromTheThree);
            //}
            //else
            //{
            //    Console.WriteLine("The biggest number is {0}", numThree);
            //}
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is {0}", GetMax(GetMax(numOne, numTwo), numThree));


        }
        static int GetMax(int numOne, int numTwo)
        {
            //if (numOne >= numTwo)
            //{
            //    return numOne;
            //}
            //else
            //{
            //    return numTwo;
            //}

            return numOne >= numTwo ? numOne : numTwo;

        }
    }
}
