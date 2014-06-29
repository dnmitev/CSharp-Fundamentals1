using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PrintFirst10MemebersOfSequence
{
    class PrintFirst10MemebersOfSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(-i);
                    Console.Write(" ");
                }                
            }
            Console.WriteLine();
        }
    }
}
