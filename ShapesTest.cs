using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public class ShapesTest
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Length = 10;
            rectangle1.Width = 15;
            rectangle1.XPosition = 5;
            rectangle1.YPosition = 6;

            Rectangle rectangle2 = new Rectangle(2, 2);

            Rectangle rectangle3 = new Rectangle(3, 4, 5, 6);

            Console.WriteLine(rectangle1.ToString());
            Console.WriteLine($"Area of Rectangle 1: {rectangle1.CalcArea()}");
            Console.WriteLine("Moving Rectangle 1 to 8, 12...");
            rectangle1.MoveTo(8, 12);
            Console.WriteLine(rectangle1.ToString());
            Console.WriteLine("Growing rectangle 1...");
            rectangle1.Grow();
            Console.WriteLine(rectangle1.ToString());

            Console.WriteLine(rectangle2.ToString());
            Console.WriteLine("Shrinking rectangle 2...");
            rectangle2.Shrink();
            Console.WriteLine(rectangle2.ToString());
            Console.WriteLine("Shrinking rectangle 2...");
            rectangle2.Shrink();
            Console.WriteLine(rectangle2.ToString());
            Console.WriteLine("Shrinking rectangle 2...");
            rectangle2.Shrink();
            Console.WriteLine(rectangle2.ToString());

            Console.WriteLine(rectangle3.ToString());


            Circle circle = new Circle(2, 3, 5);
            Console.WriteLine(circle.ToString());
         
            Console.WriteLine($"Area of circle: {circle.GetArea()}");

        }
    }
}
