//1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

namespace ExamineIntegers
{
using System;

    class ExamineIntegers
    {
        static void Main()
        {
            Console.Write("Please enter 1st integer: a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd integer: b=");
            int b =  int.Parse(Console.ReadLine());
            int bigger = a;
            if (a > b)
            {
                Console.WriteLine("{0} is bigger than {1} and there is no need of exchanging their values!", a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} is equal to {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is less than {1}", a, b);
                bigger = b;
                b = a;
                a = bigger;
                Console.WriteLine("The values after the exchange are a={0} and b={1}",a,b);
            }
            
        }
    }
}
