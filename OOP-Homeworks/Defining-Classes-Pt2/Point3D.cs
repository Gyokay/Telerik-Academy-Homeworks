namespace Defining_Classes_Pt2
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get { return o; }
        }

        public override string ToString()
        {
            return string.Format($" Point X: {this.X} \n Point Y: {this.Y} \n Point Z: {this.Z} \n");
        }

    }
}
