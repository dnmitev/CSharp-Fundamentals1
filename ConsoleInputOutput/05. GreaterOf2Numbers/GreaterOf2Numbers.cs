//5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

namespace GreaterOf2Numbers
{
    using System;

    class GreaterOf2Numbers
    {
        static void Main()
        {
            Console.Write("Please enter the 1st number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the 2nd number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is: {0}",num1 > num2 ? num1 : num2);
        }
    }
}
