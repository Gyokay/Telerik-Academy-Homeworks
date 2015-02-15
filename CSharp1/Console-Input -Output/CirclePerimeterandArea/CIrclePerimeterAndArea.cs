using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterandArea
{
    class CIrclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("radius:");
            double r = float.Parse(Console.ReadLine());
            double p = (2 * r) * (Math.PI);
            double s = Math.PI * (r * r);
            Console.WriteLine("Perimeter is: {0}", Math.Round(p, 2));
            Console.WriteLine("Area is: {0}", Math.Round(s, 2));

            Console.WriteLine();
        }
    }
}
