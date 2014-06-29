/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/6 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            //input data on the console
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());

            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());

            int h = int.Parse(Console.ReadLine());

            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());

            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());

            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            //apply symmetry to H line
            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            //find ship borders
            int maxSx = Math.Max(sx1, sx2);
            int minSx = Math.Min(sx1, sx2);

            int maxSy = Math.Max(sy1, sy2);
            int minSy = Math.Min(sy1, sy2);

            //damage points calculation
            int damage = 0;

            //check whether the corner is hitted
            if ((cx1 == minSx || cx1 == maxSx) && (cy1 == minSy || cy1 == maxSy))
            {
                damage += 25;
            }
            if ((cx2 == minSx || cx2 == maxSx) && (cy2 == minSy || cy2 == maxSy))
            {
                damage += 25;
            }
            if ((cx3 == minSx || cx3 == maxSx) && (cy3 == minSy || cy3 == maxSy))
            {
                damage += 25;
            }

            //check whether the ship's border is hitted
            if (((cx1 == minSx || cx1 == maxSx) && (cy1 < maxSy && cy1 > minSy)) ||
                ((cy1 == minSy || cy1 == maxSy) && (cx1 > minSx && cx1 < maxSx)))
            {
                damage += 50;
            }
            if (((cx2 == minSx || cx2 == maxSx) && (cy2 < maxSy && cy2 > minSy)) ||
                ((cy2 == minSy || cy2 == maxSy) && (cx2 > minSx && cx2 < maxSx)))
            {
                damage += 50;
            }
            if (((cx3 == minSx || cx3 == maxSx) && (cy3 < maxSy && cy3 > minSy)) ||
                ((cy3 == minSy || cy3 == maxSy) && (cx3 > minSx && cx3 < maxSx)))
            {
                damage += 50;
            }

            //check whether the ship is hitted inside its borders
            if ((cx1 > minSx) && (cx1 < maxSx) && (cy1 > minSy) && (cy1 < maxSy))
            {
                damage += 100;
            }
            if ((cx2 > minSx) && (cx2 < maxSx) && (cy2 > minSy) && (cy2 < maxSy))
            {
                damage += 100;
            }
            if ((cx3 > minSx) && (cx3 < maxSx) && (cy3 > minSy) && (cy3 < maxSy))
            {
                damage += 100;
            }

            //print on the console the percentage of hits
            Console.WriteLine("{0}%",damage);
        }
    }
}
