/*3. Write a program that safely compares floating-point numbers with precision of 0.000001. 
 * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true */

namespace SafelyCompareFloatingPointNumbers
{
    using System;

    class SafelyCompareFloatingPointNumbers
    {
        static void Main()
        {
            Console.Write("Please enter 1st number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd number: ");
            float num2 = float.Parse(Console.ReadLine());;
            bool compare = (num1 == num2);
            Console.WriteLine("The 2 numbers are equal is a {0} statement!",compare);
        }
    }
}
