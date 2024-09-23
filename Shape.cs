using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public abstract class Shape
    {
        //Fields
        private int xPosition;
        private int yPosition;

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

        //Constructors
        public Shape()
        {
            xPosition = 0;
            yPosition = 0;
        }

        public Shape(int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        //Methods
        public void MoveTo(int newXPosition, int newYposition)
        {
            this.XPosition = newXPosition;
            this.YPosition = newYposition;
        }

        public bool IsAtLocation(int x, int y)
        {
            if (XPosition == x && YPosition == y)
            {
                return true;
            }
            return false;
        }

        //Override methods
        public override string ToString()
        {
            return $"Shape at position x: {xPosition}, y: {yPosition}";
        }
    }
}
