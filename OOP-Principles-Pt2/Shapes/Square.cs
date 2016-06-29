namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double width)
            : base(width)
        {

        }

        public override double CalculateSurface()
        {
            return Math.Pow(Width, 2);
        }
    }
}
