/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/6 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] firTree = new char[n, 2 * (n - 1) - 1];

            int asteriskStart = n - 2;
            int asteriskEnd = asteriskStart;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < 2 * (n - 1) - 1; col++)
                {
                    if (row != n - 1)
                    {
                        if (col >= asteriskStart && col <= asteriskEnd)
                        {
                            firTree[row, col] = '*';
                        }
                        else
                        {
                            firTree[row, col] = '.';
                        }
                    }
                    else if (col != n - 2)
                    {
                        firTree[row, col] = '.';
                    }
                    else
                    {
                        firTree[row, col] = '*';
                    }
                    
                }
                asteriskStart--;
                asteriskEnd++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * (n - 1) - 1; j++)
                {
                    Console.Write(firTree[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
