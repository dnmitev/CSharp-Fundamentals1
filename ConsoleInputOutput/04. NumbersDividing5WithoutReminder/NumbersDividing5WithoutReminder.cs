/*4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2. */

namespace NumbersDividing5WithoutReminder
{
    using System;

    class NumbersDividing5WithoutReminder
    {
        static void Main()
        {
            Console.Write("Please enter 1st integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("The integers that are dividing 5 without a reminder are: ");
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    if (i != 0)
                    {
                        Console.Write("{0}; ", i);
                        count ++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("\nSo the count of the these integers is: {0}",count);
        }
    }
}
