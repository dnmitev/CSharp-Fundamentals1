/*1.Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, 
 * ulong to represent the following values: 52130, -115, 4825932, 97, -10000. */

namespace DeclaringVariables
{
    using System;

    class DeclaringVariables
    {
        static void Main()
        {
            sbyte num1 = -115;    // sbyte -> (-128;127)
            byte num2 = 97;       // byte -> (0;255)
            short num3 = -10000;  // short -> (-32768;32767)
            ushort num4 = 52130;  // ushort -> (0;65535)
            int num5 = 4825932;   // int (-2147483648;2147483647)
        }
    }
}
