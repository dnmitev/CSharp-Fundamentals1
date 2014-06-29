//3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

namespace MinMaxIntegerOfSequence
{
    using System;

    class MinMaxIntegerOfSequence
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter a number: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            int min = num[0]; //Consider that the 1st element is the biggest and compare it to the others
            int max = num[0]; //Consider that the 1st element is the smallest and compare it to the others

            for (int i = 1; i < n; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                else if (num[i] < min)
                {
                    min = num[i];
                }            
            }
            Console.WriteLine("The maximal number is: {0}", max);
            Console.WriteLine("The minimal number is: {0}", min);
        }
    }
}
