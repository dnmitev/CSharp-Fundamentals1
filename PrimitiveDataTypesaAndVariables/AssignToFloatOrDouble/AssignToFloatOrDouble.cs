/*2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
 * 34.567839023, 12.345, 8923.1234857, 3456.091? */

namespace AssignToFloatOrDouble
{
    using System;

    class AssignToFloatOrDouble
    {
        static void Main()
        {
            float num1 = 12.345f;
            float num2 = 3456.091f;
            double num3 = 34.567839023d;
            double num4 = 8923.1234857d;
            Console.WriteLine("As float are assigned {0} & {1}",num1,num2);
            Console.WriteLine("As double are assigned {0} & {1}", num3, num4);
        }
    }
}
