//6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Please enter qoefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter qoefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter qoefficient c: ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = b*b - 4*a*c;
            if (discriminant >= 0)
            {
                Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(discriminant))/(2*a));
                Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(discriminant)) / (2*a));
            }
            else
            {
                Console.WriteLine("This equatation doesn't have any real roots!");
            }
        }
    }
}
