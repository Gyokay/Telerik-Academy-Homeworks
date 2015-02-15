//7. Point in a Circle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coordinate x of the point: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y of the point: ");
            float y = float.Parse(Console.ReadLine());
            byte rad = 2;
            bool inCircle = x * x + y * y <= rad * rad;
            Console.WriteLine("{0}", inCircle);
        }
    }
}
