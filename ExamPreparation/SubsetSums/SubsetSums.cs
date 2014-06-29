/* link to BgCoder Contest:
 * http://bgcoder.com/Contest/Practice/5 */

/* Link to BGCoder
 * http://bgcoder.com/Contest/Practice/5 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            //input the wanted subset sum
            long s = long.Parse(Console.ReadLine());

            //input the how many numbers should be used
            long n = long.Parse(Console.ReadLine());

            //input the numbers
            long[] numbers = new long[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == s)
                {
                    counter++;
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    long sum = numbers[i] + numbers[j];
                    if (sum == s)
                    {
                        counter++;
                    }
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        sum = sum + numbers[k];
                        if (sum == s)
                        {
                            counter++;
                        }
                        for (int l = k + 1; l < numbers.Length; l++)
                        {
                            sum = sum + numbers[l];
                            if (sum == s)
                            {
                                counter++;
                            }
                            for (int m = l + 1; m < numbers.Length; m++)
                            {
                                sum = sum + numbers[m];
                                if (sum == s)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
