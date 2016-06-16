namespace Defining_Classes_Pt2
{
    using System;

    using System.Collections.Generic;
    using System.Text;
    public class Path
    {
        private List<Point3D> pathSeq;

        public Path()
        {
            this.pathSeq = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.pathSeq.Add(point);
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            foreach (Point3D point in this.pathSeq)
            {
                strBuilder.Append(point.ToString());

                strBuilder.Append(Environment.NewLine);
            }

            return strBuilder.ToString();
        }
    }
}
