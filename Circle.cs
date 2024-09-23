using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public class Circle
    {
        //Fields/variables
        private int xPosition;
        private int yPosition;
        private double radius;

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

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //Constructors
        public Circle()
        {
            radius = 1D;
            XPosition = 0;
            YPosition = 0;
        }

        public Circle(double radius, int x, int y)
        {
            this.radius = radius;
            XPosition = x;
            YPosition = y;
        }

        //Methods
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public bool IsAtLocation(int x, int y)
        {
            if (this.xPosition == x && this.yPosition == y)
            {
                return true;
            }
            return false;
        }

        //Overrride Methods
        public override string ToString()
        {
            return $"Circle - radius: {radius}, at x: {XPosition}, y: {YPosition}";
        }
    }
}
