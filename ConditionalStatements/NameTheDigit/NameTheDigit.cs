//5. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.


namespace NameTheDigit
{
    using System;

    class NameTheDigit
    {
        static void Main()
        {
            byte n;
            do
            {
                Console.Write("Please enter a digit: ");
                n = byte.Parse(Console.ReadLine());

            } while (n > 9);
            switch (n)
            {
                case 0:
                    Console.WriteLine("{0} --> zero", n);
                    break;
                case 1:
                    Console.WriteLine("{0} --> one", n);
                    break;
                case 2:
                    Console.WriteLine("{0} --> two", n);
                    break;
                case 3:
                    Console.WriteLine("{0} --> three", n);
                    break;
                case 4:
                    Console.WriteLine("{0} --> four", n);
                    break;
                case 5:
                    Console.WriteLine("{0} --> five", n);
                    break;
                case 6:
                    Console.WriteLine("{0} --> six", n);
                    break;
                case 7:
                    Console.WriteLine("{0} --> seven", n);
                    break;
                case 8:
                    Console.WriteLine("{0} --> eight", n);
                    break;
                case 9:
                    Console.WriteLine("{0} --> nine", n);
                    break;
                default: Console.WriteLine("You didn't enter a digit!!!");
                    break;
            }
        }
    }
}
