namespace Shapes
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Hieight { get; set; }

        public Shape(double width)
        {
            this.Width = width;
            this.Hieight = width;
        }

        public Shape(double width, double height)
            : this(width)
        {
            this.Hieight = height;
        }


        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format($"The area of the {this.GetType().Name} is : {CalculateSurface()}");
        }
    }
}
