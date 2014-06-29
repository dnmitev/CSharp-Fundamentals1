/* 8. Declare two string variables and assign them with following value:
 *  
 *             The "use" of quotations causes difficulties.
 *
 * 	Do the above in two different ways: with and without using quoted strings. */


namespace EscapingQuotationMarks
{
    using System;

    class EscapingQuotationMarks
    {
        static void Main()
        {
            string text1 = "The \"use\" of quatations causes difficulties";
            Console.WriteLine("When I use \\ symbol, it would print on the console this string: {0}", text1);
            string text2 = @"The ""use"" of quatations causes difficulties";
            Console.WriteLine("When I use @ symbol, it would print on the console this string: {0}", text2);
        }
    }
}
