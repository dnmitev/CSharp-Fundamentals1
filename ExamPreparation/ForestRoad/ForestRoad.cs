/* link to BgCoder Contest:
 * http://bgcoder.com/Contest/Practice/5 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            //input the width on the console
            int width = int.Parse(Console.ReadLine());

            char[,] topMap = new char[(2*width - 1)/2,width];

            int asteriskCounterTop = 0;

            for (int row = 0; row < (2*width - 1)/2; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == asteriskCounterTop)
                    {
                        topMap[row,col] = '*';
                    }
                    else
                    {
                        topMap[row, col] = '.';
                    }
                }
                asteriskCounterTop++;
            }

            for (int row = 0; row < (2 * width - 1) / 2; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(topMap[row,col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('.',width-1)+"*");

            char[,] bottomMap = new char[(2 * width - 1) / 2, width];

            int asteriskCounterBottom = width - 2;

            for (int row = 0; row < (2 * width - 1) / 2; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == asteriskCounterBottom)
                    {
                        bottomMap[row, col] = '*';
                    }
                    else
                    {
                        bottomMap[row, col] = '.';
                    }
                }
                asteriskCounterBottom--;
            }

            for (int row = 0; row < (2 * width - 1) / 2; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(bottomMap[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
