//13. Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
//Examples:
//	N = 10 -> N! = 3628800 -> 2
//	N = 20 -> N! = 2432902008176640000 -> 4

namespace TrailingZeros
{
    using System;

    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Please enter value for N: ");
            int n = int.Parse(Console.ReadLine());   //enter value for n

            int sum = n / 5;
            int powValue = 1;
            int power = 2;
            do
            {
                powValue = (int) Math.Pow(5, power);
                power++;
                sum = sum + n / powValue;
            } while (powValue < n);

            Console.WriteLine("{0}! would have {1} trailing zeros!", n, sum);
        }
    }
}
