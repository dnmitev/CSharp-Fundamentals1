/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/7 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            int[] appearingsCount = new int[n];

            bool[] skip = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (skip[i])
                {
                    continue;
                }
                else
                {
                    long currentNumber = numbers[i];

                    for (int j = 0; j < n; j++)
                    {
                        if (numbers[j] == currentNumber)
                        {
                            skip[j] = true;
                            appearingsCount[i]++;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if ((appearingsCount[i] & 1) == 1)
                {
                    Console.WriteLine(numbers[i]);
                    break;
                }
            }
        }
    }
}
