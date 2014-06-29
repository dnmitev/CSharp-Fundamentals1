//7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members

namespace SumFibonacciSequenceMembers
{
    using System;

    class SumFibonacciSequenceMembers
    {
        static void Main()
        {
            Console.Write("Please enter N=");
            int n = int.Parse(Console.ReadLine());

            decimal[] fibonacci = new decimal[n];
            decimal sum = 0;
            for (int i = 0; i < n; i++)
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

                sum += fibonacci[i];
            }

            Console.WriteLine("The sum of the 1st {0} members of the Fibonacci's sequence is: {1}", n, sum);
        }
    }
}
