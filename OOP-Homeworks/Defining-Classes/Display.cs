using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public class Display
    {
        private const int defaoultSize = 100;
        private const int defaoultNumberOfColors = 200;

        private int size;
        private int numberOfColors;

        public Display() : this(defaoultSize, defaoultNumberOfColors) { }

        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("size must be greather then 0");
                }

                size = value;
            }
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Number of color must be greater then 0");
                }

                numberOfColors = value;
            }
        }
    }
}
