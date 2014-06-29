//9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

namespace IsoscelesTriangleCopyright
{
    using System;
    using System.Text;

    class IsoscelesTriangleCopyright
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char c = '\u00A9';
            Console.WriteLine(@"This is supposed to be ab isosceles triangle of copyright marks:
     {0}
    {0} {0}
   {0}   {0}
  {0} {0} {0} {0}", c);
        }
    }
}
