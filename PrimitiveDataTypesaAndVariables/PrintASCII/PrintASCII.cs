﻿//12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

namespace PrintASCII
{
    using System;
    using System.Text;

    class PrintASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 127; i++)
            {
                Console.WriteLine(" " + (char)i);
            }
        }
    }
}
