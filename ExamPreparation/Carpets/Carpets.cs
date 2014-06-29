/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/79 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main()
        {
            //input width and height from the console
            int n = int.Parse(Console.ReadLine());

            char leftSide = '/';
            char rightSide = '\\';
            char space = ' ';

            int startOfRomb = n / 2 - 1;
            int endOfRomb = n / 2;

            for (int rows = 0; rows < n; rows++)
            {
                if (rows == (n / 2))
                {
                    //exchange values if the mid-line is reached
                    char help = leftSide;
                    leftSide = rightSide;
                    rightSide = help;

                    startOfRomb = 0;
                    endOfRomb = n - 1;
                }

                for (int col = 0; col < startOfRomb; col++)
                {
                    Console.Write(".");
                }

                int target = n - (2 * startOfRomb);

                for (int col = 0; col < target; col++)
                {
                    if (col < target / 2)
                    {
                        Console.Write(col % 2 == 0 ? leftSide : space);
                    }
                    else
                    {
                        Console.Write(col % 2 != 0 ? rightSide : space);
                    }
                }

                for (int col = 0; col < startOfRomb; col++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();

                if (rows < (n / 2))
                {
                    startOfRomb--;
                    endOfRomb++;
                }
                else
                {
                    startOfRomb++;
                    endOfRomb--;
                }
            }
        }
    }
}
