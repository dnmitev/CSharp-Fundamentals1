//8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

namespace PrintNumbers
{
    using System;

    class PrintNumbers
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Please enter n : ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 1);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Number No.{0}: {1}", i, i);
            }
        }
    }
}
