//2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

namespace SignOfProduct
{
    using System;

    class SignOfProduct
    {
        static void Main()
        {
            double[] num = new double[3];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Please enter number: ");
                num[i] = double.Parse(Console.ReadLine());
            }
            bool isPositive = true;
            byte count = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0)
                {
                    if ((num[i] < 0) && (count % 2 != 0))
                    {
                        isPositive = false;
                        count++;
                    }
                    else
                    {
                        isPositive = true;
                    }
                }
                else
                {
                    Console.WriteLine("The product is 0!");
                    count = 0;
                    break;
                }
            }
            if (count != 0)
            {
                if (isPositive)
                {
                    Console.WriteLine("The product would have positive (+) sign!");
                }
                else
                {
                    Console.WriteLine("The product would have negative (-) sign!");
                }
            }
        }
    }
}
