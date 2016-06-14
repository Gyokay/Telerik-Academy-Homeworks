namespace Defining_Classes_Pt2
{
    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D pOne, Point3D pTwo)
        {
            double distance = Math.Sqrt(Math.Pow((pOne.X - pTwo.X), 2)
                                + Math.Pow((pOne.Y - pTwo.Y), 2)
                                + Math.Pow((pOne.Z - pTwo.Z), 2));

            return distance;
        }
    }
}
