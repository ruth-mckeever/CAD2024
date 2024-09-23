using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAD2024
{
    public class ShapesTest
    {
        static void Main(string[] args)
        {
            //InitialTesting(); // Note: calling a method that has no return type...
            ArrayTesting();
        }

        public static void ArrayTesting()
        {
            //Question 4
           /** 
            Rectangle rectangle1 = GetUserRectangle();
            Console.WriteLine(rectangle1.ToString());

            Circle circle1 = GetUserCircle();
            Console.WriteLine(circle1.ToString());
           */

            Rectangle[] myRectangles = new Rectangle[3];
            for (int i = 0; i < 3; i++)
            {
                Rectangle rectangle = GetUserRectangle();
                myRectangles[i] = rectangle;
            }

            foreach (Rectangle rectangle in myRectangles)
            {
                Console.WriteLine(rectangle.ToString());
            }

            foreach (Rectangle rectangle in myRectangles)
            {
                Console.WriteLine(rectangle.Width);
            }

            foreach (Rectangle rectangle in myRectangles)
            {
                Console.WriteLine("Shrinking each rectangle by 2");
                //I'm only decreasing the width by 2, not 20 (question 4.g)
                rectangle.Shrink(2);
                Console.WriteLine(rectangle.ToString());
            }
            double combinedArea = GetTotalArea(myRectangles);
            Console.WriteLine($"Total area of all rectangles is: {combinedArea}");

        }

        public static double GetTotalArea(Rectangle[] rectangleArray)
        {
            double totalArea = 0;   
            foreach(Rectangle rectangle in rectangleArray)
            {
                totalArea += rectangle.CalcArea();
            }
            return totalArea;
        }

        public static Rectangle GetUserRectangle()
        {
            
            Console.WriteLine("Enter rectangle width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rectangle length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rectangle x position:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rectangle y position:");
            int y = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width, x, y);
            return rectangle;
        }

        public static Circle GetUserCircle()
        {
            Console.WriteLine("Enter circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter circle x position:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter circle y position:");
            int y = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle(radius, x, y);
            return circle;
        }

        public static void InitialTesting()
        {
            //I want to keep these tests but not necessarily see them every time I run the program
            // so I'm moving them out into a method of their own.
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

            //Check circle is at location, and move to methods
            bool isThere = circle.IsAtLocation(1, 1);       // Calling a method that has a return type - set it equal to something
            Console.WriteLine($"Circle is at location 2, 2: {isThere}");
            circle.MoveTo(2, 2);
            isThere = circle.IsAtLocation(2, 2);
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"Circle is at location 2, 2: {isThere}");

            Circle circle2 = new Circle(5, 2, 2);
            if (circle2.IsAtLocation(circle.XPosition, circle.YPosition))
            {
                Console.WriteLine("Both circles at same position");
            }
            else
            {
                Console.WriteLine("Both circles are at different positions");
            }
        }
    }
}
