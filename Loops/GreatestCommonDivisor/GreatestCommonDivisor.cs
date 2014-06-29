//8.Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

namespace GreatestCommonDivisor
{
    using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            //Find bigger of two values and chech whether one of the values is 0
            if (num1 < num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
            }
            else if (num1 == 0)
            {
                Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, num2);
            }
            else if (num2 == 0)
            {
                Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, num1);
            }

            //Loop values till the ramainder is 0 (The Euclidean algorithm)
            int remainder;
            int a = num1;
            int b = num2;
            do
            {
                remainder = a % b;
                if (remainder == 0)
                {
                    break;
                }
                else
                {
                    a = b;
                    b = remainder;
                }
            } while (remainder != 0);

            Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, b);
        }
    }
}
