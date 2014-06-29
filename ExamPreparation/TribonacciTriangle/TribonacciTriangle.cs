/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/79 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main()
        {
            //input 1st three Tribonacci's integers
            decimal leftTribonacciNumber = decimal.Parse(Console.ReadLine());
            decimal middleTribonacciNumber = decimal.Parse(Console.ReadLine());
            decimal rightTribonacciNumber = decimal.Parse(Console.ReadLine());

            //input the number of lines
            int lineNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(leftTribonacciNumber);
            Console.WriteLine("{0} {1}", middleTribonacciNumber, rightTribonacciNumber);

            int currentCol = 0;
            int currentLine = 3;

            while (currentLine <= lineNumber)
            {
                decimal currentTribonacciNumber = leftTribonacciNumber + middleTribonacciNumber + rightTribonacciNumber;

                leftTribonacciNumber = middleTribonacciNumber;
                middleTribonacciNumber = rightTribonacciNumber;
                rightTribonacciNumber = currentTribonacciNumber;

                currentCol++;

                if (currentCol < currentLine)
                {
                    Console.Write("{0} ", currentTribonacciNumber);
                }
                else
                {
                    Console.WriteLine(currentTribonacciNumber);
                    currentCol = 0;
                    currentLine++;
                }
            }
        }
    }
}
