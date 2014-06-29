/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/7 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            //input n0.........n7 on the console
            byte[] numbers = new byte[8];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = byte.Parse(Console.ReadLine());
            }

            //store the binary values of the digits in a matrix
            char[,] binaryArray = new char[8, 8];

            for (int row = 0; row < numbers.Length; row++)
            {
                string binaryNumber = Convert.ToString(numbers[row], 2);
                binaryNumber = binaryNumber.PadLeft(8, '0');

                for (int col = 0; col < 8; col++)
                {
                    binaryArray[row, col] = binaryNumber[col];
                }
            }

            //'1' symbols fall down
            int counter = 0;

            do
            {

                for (int row = 6; row >= 0; row--)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if (binaryArray[row, col] == '1' && binaryArray[row + 1, col] != '1')
                        {
                            binaryArray[row, col] = '0';
                            binaryArray[row + 1, col] = '1';
                        }
                    }
                }
                counter++;
            } while (counter < 7);

            //represent the decimal number of the binaries in the char matrix
            for (int row = 0; row < 8; row++)
            {
                numbers[row] = 0;
                for (int col = 0; col < 8; col++)
                {
                    if (binaryArray[row, col] == '1')
                    {
                        numbers[row] += (byte)Math.Pow((double)2, (double)(7 - col));
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
