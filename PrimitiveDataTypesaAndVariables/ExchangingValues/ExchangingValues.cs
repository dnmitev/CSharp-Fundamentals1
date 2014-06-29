//11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

namespace ExchangingValues
{
    using System;

    class ExchangingValues
    {
        static void Main()
        {
            int num1 = 5;
            int num2 = 11;
            Console.WriteLine("The first number is {0} and the second number is {1}", num1, num2);
            int helpNum = num1;
            num1 = num2;
            num2 = helpNum;
            Console.WriteLine("After exchanging the first number is {0} and the second is {1}", num1, num2);
        }
    }
}
