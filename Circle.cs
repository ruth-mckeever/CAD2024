using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public class Circle : Shape
    {
        //Fields/variables
        private double radius;

        //Properties
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //Constructors
        public Circle()
        {
            radius = 1D;
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

        //Overrride Methods
        public override string ToString()
        {
            return $"Circle - radius: {radius}, {base.ToString()}";
        }
    }
}
