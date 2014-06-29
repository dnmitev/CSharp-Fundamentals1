/*Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/133 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class BatGoikoTower
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int width = 2 * h;

            int towerWidth = 2;
            int nextCrossbeamRow = 2;
            int currentStep = 2;
            for (int row = 1; row <= h; row++)
            {
                string sidepoints = new string('.', (width - towerWidth) / 2);
                string middleSymbols;
                if (row % nextCrossbeamRow == 0)
                {
                    middleSymbols = new string('-', width - (sidepoints.Length * 2) - 2);
                    nextCrossbeamRow += currentStep;
                    currentStep++;
                }
                else
                {
                    middleSymbols = new string('.', width - (sidepoints.Length * 2) - 2);
                }
                Console.WriteLine(sidepoints + "/" + middleSymbols + "\\" + sidepoints);
                towerWidth += 2;
            }
        }
    }
}