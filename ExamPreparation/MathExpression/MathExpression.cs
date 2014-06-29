/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/7 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double result = 0u;

            result = (Math.Pow(n, 2) + Math.Pow((m * p),-1) + 1337) / (n - 128.523123123 * p) + Math.Sin((int)m % 180);

            Console.WriteLine("{0:F6}", result);
        }
    }
}
