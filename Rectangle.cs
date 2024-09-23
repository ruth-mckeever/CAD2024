using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CAD2024
{
    public class Rectangle : Shape
    {
        //Fields
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //Constructors
        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(double length, double width, int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            this.length = length;
            this.width = width;
        }

        //Methods
        public double CalcArea()
        {
            return Length * Width;
        }

        public void Grow()
        {
            this.Grow(1.0);
            //Length++;
            //Width++;
        }
        public void Grow(double growValue)
        {
            length = length + growValue;
            width += growValue;             // += does the same thing as width = with + growValue
        }

        public void Shrink()
        {
            this.Shrink(1.0);
            /*if (length >= 1)
            {
                length--;
            }
            if (width >= 1)
            {
                width--;
            }
            */
        }

        public void Shrink(double shrinkValue)
        {
            if (length >= shrinkValue)
            {
                length = length - shrinkValue;
            }
            if (width >= shrinkValue)
            {
                width -= shrinkValue;       // -= does the same as width = width - shrinkValue
            }
        }

        //Override methods
        public override string ToString()
        {
            return $"Rectangle - Width: {Width}, Length: {Length}, {base.ToString()}";
        }

    }
}
