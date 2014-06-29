//1. Write a program that reads 3 integer numbers from the console and prints their sum.

namespace ReadIngerersAndPrintTheirSum
{
    using System;

    class ReadIngerersAndPrintTheirSum
    {
        static void Main()
        {
            Console.Write("Please enter the 1st integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the 2nd integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the 3rd integer: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum will be: {0} + {1} + {2} = {3}", num1, num2, num3, num1 + num2 + num3);
        }
    }
}
