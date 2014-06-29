/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/7 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            //input the small base width
            int n = int.Parse(Console.ReadLine());

            char[,] trapezoidArray = new char[2 * n + 1, 2 * n];

            for (int row = 0; row < n + 1; row++)
            {
                int asteriskStartPosition = n - row;

                for (int col = 0; col < 2 * n; col++)
                {
                    if (row == 0)
                    {
                        if (col < asteriskStartPosition)
                        {
                            trapezoidArray[row, col] = '.';
                        }
                        else
                        {
                            trapezoidArray[row, col] = '*';
                        }
                    }
                    else if (col != asteriskStartPosition && col != 2 * n - 1)
                    {
                        trapezoidArray[row, col] = '.';
                    }
                    else
                    {
                        trapezoidArray[row, col] = '*';
                    }

                    if (row == n)
                    {
                        trapezoidArray[row, col] = '*';
                    }
                }
            }

            for (int row = 0; row < n + 1; row++)
            {
                for (int col = 0; col < 2 * n; col++)
                {
                    Console.Write(trapezoidArray[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
