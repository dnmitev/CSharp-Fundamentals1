//3. Write a program that finds the biggest of three integers using nested if statements.

namespace BiggestOfIntegers
{
    using System;

    class BiggestOfIntegers
    {
        static void Main()
        {
            Console.Write("Please enter 1st integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter 3rd integer: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number among {0},{1},{2} is {3}",a,b,c,a);
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("The biggest number among {0},{1},{2} is {3}", a, b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number among {0},{1},{2} is {3}", a, b, c, c);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number among {0},{1},{2} is {3}", a, b, c, b);
                }
                else
                {
                    Console.WriteLine("The biggest number among {0},{1},{2} is {3}", a, b, c, c);
                }
            }
        }
    }
}
