//4. Write a program that calculates N!/K! for given N and K (1<K<N).

namespace FactorialDividedByFactorial
{
    using System;

    class FactorialDividedByFactorial
    {
        static void Main()
        {
            int k, n;
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());

            // Be sure that the value entered for K is 1<K<N
            do
            {
                Console.Write("K = ");
                k = int.Parse(Console.ReadLine());
            } while ((k < 1) || (k >= n));

            ulong result = 1; //initially assign result as 1 to safely multiply

            for (int i = k+1; i <= n; i++)
            {
                result *= (ulong)i;  // N!/K! = (N-K+1)*N
            }

            Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
        }
    }
}
