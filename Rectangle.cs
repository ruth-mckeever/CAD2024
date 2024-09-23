using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public class Rectangle
    {
        //Fields
        private int xPosition;
        private int yPosition;
        private double length;
        private double width;

        //Properties
        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

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
            this.xPosition = 0;
            this.yPosition = 0;
            this.length = 0;
            this.width = 0;
        }

        public Rectangle(double length, double width)
        {
            this.xPosition = 0;
            this.yPosition = 0;
            this.length = length;
            this.width = width;
        }
        public Rectangle(double length, double width, int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.length = length;
            this.width = width;
        }

        //Methods
        public double CalcArea()
        {
            return Length * Width;
        }

        public void MoveTo(int newXPosition, int newYposition)
        {
            this.XPosition = newXPosition;
            this.YPosition = newYposition;
        }

        public void Grow()
        {
            Length++;
            Width++;
        }

        public void Shrink()
        {
            if (Length >= 1)
            {
                Length--;
            }
            if (Width >= 1)
            {
                Width--;
            }
        }

        //Override methods
        public override string ToString()
        {
            return $"Rectangle - Width: {Width}, Length: {Length}, at x: {XPosition}, y: {YPosition}";
        }

    }
}
