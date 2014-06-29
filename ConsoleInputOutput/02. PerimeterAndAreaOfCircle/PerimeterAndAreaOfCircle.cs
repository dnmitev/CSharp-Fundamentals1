//2. Write a program that reads the radius r of a circle and prints its perimeter and area.

namespace PerimeterAndAreaOfCircle
{
    using System;

    class PerimeterAndAreaOfCircle
    {
        static void Main()
        {
            Console.Write("Please enter the circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Circle has perimeter of {0} and area of {1}",perimeter,area);
        }
    }
}
