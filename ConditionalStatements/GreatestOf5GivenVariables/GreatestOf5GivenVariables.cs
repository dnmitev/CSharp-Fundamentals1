//7. Write a program that finds the greatest of given 5 variables.

namespace GreatestOf5GivenVariables
{
    using System;

    class GreatestOf5GivenVariables
    {
        static void Main()
        {
            double[] num = new double[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Please enter a number: ");
                num[i] = double.Parse(Console.ReadLine());
            }

            double biggest = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > biggest)
                {
                    biggest = num[i];
                }
            }
            Console.WriteLine("The greatest number is {0}",biggest);
        }
    }
}
