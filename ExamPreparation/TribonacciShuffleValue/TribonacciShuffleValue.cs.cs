/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/6 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TribonacciShuffleValue
{
    class TribonacciShuffleValue
    {
        static void Main()
        {
            BigInteger firstTribonacciMember = BigInteger.Parse(Console.ReadLine());
            BigInteger secondTribonacciMember = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdTribonacciMember = BigInteger.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            BigInteger[] tribonacci = new BigInteger[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tribonacci[i] = firstTribonacciMember;
                }
                else if (i == 1)
                {
                    tribonacci[i] = secondTribonacciMember;
                }
                else if (i == 2)
                {
                    tribonacci[i] = thirdTribonacciMember;
                }
                else
                {
                    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                }
            }

            Console.WriteLine(tribonacci[n - 1]);
        }
    }
}
