//8. Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, 
//increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

namespace IntDoubleOrString
{
    using System;

    class IntDoubleOrString
    {
        static void Main()
        {
            Console.Write("Pleas enter value (1 -> int; 2 -> double; 3 -> string):");
            byte numericValue = byte.Parse(Console.ReadLine());
            Console.WriteLine("Done!");

            switch (numericValue)
            {
                case 1:
                    Console.Write("Enter a value: ");
                    int intValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("So the program gives you: {0}", intValue + 1);
                    break;
                case 2:
                    Console.Write("Enter a value: ");
                    double doubleValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("So the program gives you: {0}", doubleValue + 1);
                    break;
                case 3:
                    Console.Write("Enter a value: ");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine("So the program gives you: {0}", stringValue + "*");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
