/*Link to BgCoder
 * http://bgcoder.com/Contest/Practice/131 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class DrunkenNumbers //done at the academy
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int drunkenNumberIndex = 0; drunkenNumberIndex < n; drunkenNumberIndex++)
            {
                long absNumber = long.Parse(Console.ReadLine()); //removing leading 0
                absNumber = Math.Abs(absNumber);
                string input = absNumber.ToString();  
                //input = input.TrimStart(new char[] { '0', '-' });  

                for (int i = 0; i < (input.Length + 1) / 2; i++)
                {
                    int digit = input[i] - '0';
                    leftSum += digit;
                }

                for (int i = input.Length / 2; i < input.Length; i++)
                {
                    int digit = input[i] - '0';
                    rightSum += digit;
                }
            }

            if (leftSum < rightSum)
            {
                Console.WriteLine("V " + (rightSum - leftSum));
            }
            else if (leftSum >rightSum)
            {
                Console.WriteLine("M " + (leftSum - rightSum));
            }
            else
            {
                Console.WriteLine("No " + (leftSum + rightSum));
            }
        }
    }
}
