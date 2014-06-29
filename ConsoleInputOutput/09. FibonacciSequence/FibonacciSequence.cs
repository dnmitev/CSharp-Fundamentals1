//8. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

namespace FibonacciSequence
{
    using System;

    class FibonacciSequence
    {
        static void Main()
        {
            decimal[] fibonacci = new decimal[100];
            for (int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    fibonacci[i] = 0;
                }
                else
                {
                    if ((i == 1) || (i == 2))
                    {
                        fibonacci[i] = 1;
                    }
                    else
                    {
                        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                    }
                }
                Console.WriteLine("{0,3} | {1,23}", i + 1, fibonacci[i]);
            }
        }
    }
}
