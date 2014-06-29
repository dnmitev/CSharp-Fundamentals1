//13. Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

namespace AssignNullValue
{
    using System;
    class AssignNullValue
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
            a += null; // Adding null to null always is a null!
            b += 3.1415926; 
            Console.WriteLine("Printed on the console, the null assigned variables look like: a: {0} b: {1}", a, b);
        }
    }
}
