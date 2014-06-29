//4. Sort 3 real values in descending order using nested if statements.

namespace DescendingSortRealNumbers
{
    using System;

    class DescendingSortRealNumbers
    {
        static void Main()
        {
            Console.Write("Please enter 1st doubleeger: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd doubleeger: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter 3rd doubleeger: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("Descending sort: {0} >= {1} >= {2}", a, b, c);
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("Descending sort: {0} >= {1} >= {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("Descending sort: {0} >= {1} >= {2}", c, a, b);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Descending sort: {0} >= {1} >= {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Descending sort: {0} >= {1} >= {2}", c, b, a);
                }
            }
        }
    }
}
