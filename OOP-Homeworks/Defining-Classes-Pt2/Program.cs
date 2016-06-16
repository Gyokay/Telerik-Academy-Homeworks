using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D foo = new Point3D();

            //Console.WriteLine(foo.ToString());

            Console.WriteLine(Point3D.O.ToString());

            double distance = DistanceCalculator.CalculateDistance(new Point3D(5, 6, 2), new Point3D(-7, 11, -13));
            Console.WriteLine("Calculated distance:");
            Console.WriteLine(distance);
            Console.WriteLine();

            Path somePath = new Path();

            var point = new Point3D(1, 23, 3);
            var anotherPoint = new Point3D(23, 23, 324);
            somePath.AddPoint(point);
            somePath.AddPoint(anotherPoint);

            Console.WriteLine(somePath.ToString());
        }
    }
}
