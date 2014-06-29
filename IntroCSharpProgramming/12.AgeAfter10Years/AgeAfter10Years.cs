using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("My current age is: ");
            int AgeNow = int.Parse(Console.ReadLine());
            Console.Write("After 10 years I would be ");
            Console.Write(AgeNow+10);
            Console.WriteLine(" years old.");
        }
    }
}
