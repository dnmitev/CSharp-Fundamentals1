//9. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: (2n)!/[(n+1)!n!]
//Write a program to calculate the Nth Catalan number by given N.

namespace CatalanNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Please enter n= ");
                n = int.Parse(Console.ReadLine());   
            } while (n < 0);    //enter values for n till n>=0


            ulong factorial2n = 1; //stands for (2n)!
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial2n *= (ulong)i;
            }

            ulong factorialn1 = 1; // stands for (n+1)!
            for (int i = 1; i <= n + 1; i++)
            {
                factorialn1 *= (ulong) i;
            }

            ulong nFactorial = 1; // stands for (n)!
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= (ulong) i;
            }

            Console.WriteLine("The result is : {0}" , (double) (factorial2n / (factorialn1 * nFactorial)));
        }
    }
}
