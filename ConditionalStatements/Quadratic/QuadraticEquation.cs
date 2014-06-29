/*6. Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots. */


namespace Quadratic
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
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(discriminant)) / (2 * a));
                Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(discriminant)) / (2 * a));
            }
            else if ((discriminant == 0) && (a != 0))
            {
                Console.WriteLine("x1 = x2 = {0}", (-b  / (2 * a)));
            }
            else 
            {
                Console.WriteLine("This equatation doesn't have any real roots!");
            }	
        }
    }
}
