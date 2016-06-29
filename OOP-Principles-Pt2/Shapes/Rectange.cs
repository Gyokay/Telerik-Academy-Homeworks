namespace Shapes
{
    public class Rectange : Shape
    {
        public Rectange(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return Hieight * Width;
        }
    }
}
