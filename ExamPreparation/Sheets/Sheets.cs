/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/79 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            //input the number of pieces to be cut
            int N = int.Parse(Console.ReadLine());

            for (int i = 10; i >= 0; i--)
            {
                int sheets = (int)Math.Pow(2, i);

                if (N >= sheets) //check whether the whole list can be used
                {
                    N -= sheets; //find how many pieces are left to be cut
                }
                else
                {
                    Console.WriteLine("A{0}",10 - i);
                }
            }
        }
    }
}
