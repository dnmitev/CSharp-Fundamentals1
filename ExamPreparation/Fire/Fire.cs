/*Link to BgCoder
 * http://bgcoder.com/Contest/Practice/131 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main()
        {
            //initializing the width of the row
            int width = int.Parse(Console.ReadLine()); //[4;76] divisible by 4

            //drawing the top of torch's flame
            for (int i = 0; i < width / 2; i++)
            {
                string leftPartOfFlame = new string('.', width / 2 - i -1);
                string middlePartOfFlame = new string('.', 2*i);
                Console.WriteLine(leftPartOfFlame + "#" + middlePartOfFlame + "#" + leftPartOfFlame);
            }

            //drawing the bottom of torch's flame
            for (int i = width /4; i > 0; i--)
            {
                string leftPartOfFlame = new string('.', width / 4 - i);
                string middlePartOfFlame = new string('.', 2 * (width /4 + (i - 1)));
                Console.WriteLine(leftPartOfFlame + "#" + middlePartOfFlame + "#" + leftPartOfFlame);
            }

            //drawing the torch's top
            string topOfTheTorch = new string('-', width);
            Console.WriteLine(topOfTheTorch);

            //drawing the torch
            for (int i = width / 2; i > 0; i--)
            {
                string leftPartOfTorch = new string('.', width / 2 - i);
                string middleLeftPartOfTorch = new string('\\', i);
                string middleRightPartOfTorch = new string('/', i);
                Console.WriteLine(leftPartOfTorch + middleLeftPartOfTorch + middleRightPartOfTorch + leftPartOfTorch);
            }

        }
    }
}
