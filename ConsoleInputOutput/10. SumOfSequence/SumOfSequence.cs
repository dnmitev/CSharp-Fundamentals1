//10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

namespace SumOfSequence
{
    using System;

    class SumOfSequence
    {
        static void Main()
        {
            decimal sum = 1.0m;
            decimal counter = 2.0m;
            int sign = 1;
            while ((1.0m / counter) >= 0.001m)
            {
                sum = sum + (1.0m / counter) * sign;
                sign = sign * (-1);
                counter++;
            }
            Console.WriteLine("The sequence's sum is: {0:0.000}",sum);
        }
    }
}
