//11. *Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
/* Examples: 
            * 0 -> "Zero
            * 273 -> "Two hundred seventy three"
            * 400 -> "Four hundred"
            * 501 -> "Five hundred and one"
            * 711 -> "Seven hundred and eleven" */

namespace NumberToText
{
    using System;


    class NumberToText
    {
        static void Main()
        {
            //assigning two arrays containig string values for the special cases of numbers
            string[] specials = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine", "ten", "eleven", 
                                  "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int input = 0;
            // assure that the entered value is within [0...999]
            do
            {
                Console.Write("Please enter a numerical value: ");
                input = int.Parse(Console.ReadLine());
            } while (input < 0 || input > 999);

            //find the digit that stands for each position in the input number
            int units = input % 10;
            int decimals = (input / 10) % 10;
            int hundreds = input / 100;

            //check whether the number is 1,2 or 3 digit one and print its string representation
            if (input <= 19)
            {
                Console.WriteLine("{0} -> {1}", input, specials[input]);
            }
            else
            {
                if (input < 100)
                {
                    if (units == 0) //avoid printing zero when the numbers ends with 0, example: 50 -> fifty
                    {
                        Console.WriteLine("{0} -> {1}", input, tens[decimals - 2]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1} {2}", input, tens[decimals - 2], specials[units]);
                    }
                }
                else
                {
                    if (units != 0)  //avoid printing zero when the numbers ends with 0, example: 350 -> three hundred and fifty
                    {
                         Console.WriteLine("{0} -> {1} hundred and {2} {3}", input, specials[hundreds], tens[decimals - 2], specials[units]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1} hundred and {2}", input, specials[hundreds], tens[decimals - 2]);
                    }            
                }
            }
        }
    }
}
