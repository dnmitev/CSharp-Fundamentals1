/* link to BgCoder Contest:
 * http://bgcoder.com/Contest/Practice/5 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitCount
{
    class BinaryDigitCount
    {
        static void Main(string[] args)
        {
            string binaryDigit = Console.ReadLine();
            int countOfNumbers = int.Parse(Console.ReadLine());

            int[] countOfDigits = new int[countOfNumbers];

            for (int count = 0; count < countOfNumbers; count++)
            {
                long number = long.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(number, 2); 

                int found = binaryNumber.IndexOf(binaryDigit);
                int counter = 0;
                while (found != -1)
                {
                    found = binaryNumber.IndexOf(binaryDigit, found + 1);
                    counter++;
                }

                countOfDigits[count] = counter;
            }

            for (int count = 0; count < countOfDigits.Length; count++)
            {
                Console.WriteLine(countOfDigits[count]);
            }
        }
    }
}
