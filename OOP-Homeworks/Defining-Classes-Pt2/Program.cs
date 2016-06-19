namespace Defining_Classes_Pt2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
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

            PathStorage.LoadPath();

        }
    }
}
