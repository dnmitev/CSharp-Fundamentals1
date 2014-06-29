//5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

namespace FactorialMaths
{
    using System;

    class FactorialMaths
    {
        static void Main()
        {
            int k, n;
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());

            // Be sure that the value entered for N is 1<N<K
            do
            {
                Console.Write("N = ");
                n = int.Parse(Console.ReadLine());
            } while ((n < 1) || (n >= k));

            ulong nFactorial = 1;
            for (int i = 2; i <= n; i++)
            {
                nFactorial *= (ulong)i; //return the value of N!
            }

            ulong kFactorial = 1;
            for (int i = k - n + 1; i <= k; i++)
            {
                kFactorial *= (ulong)i; //return the value of K!/(K-N)!
            }

            Console.WriteLine("({0}!*{1}!)/({1} - {0})! = {2}", n, k, nFactorial*kFactorial);
        }
    }
}
