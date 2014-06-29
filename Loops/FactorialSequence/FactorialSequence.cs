//6.Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

namespace FactorialSequence
{
    using System;

    class FactorialSequence
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());

            double factorial = 1.0d;
            double resultS = 1.0d;
            for (int i = 1; i <= n; i++)
            {
                factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j; //Doing the 1!.......n! maths
                }
                resultS = resultS + factorial / Math.Pow(x, i);
            }

            Console.WriteLine("The result is: {0}",resultS);
        }
    }
}
