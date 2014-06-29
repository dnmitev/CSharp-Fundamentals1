//7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

namespace SumOfNNumbers
{
    using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Please enter n : ");
                n = int.Parse(Console.ReadLine());           
            } while (n <= 0);    
            int sum = 0;
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter number No. {0}: ", i+1);
                num [i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }
            Console.WriteLine("The sum of the entered numbers is {0}",sum);
        }
    }
}
