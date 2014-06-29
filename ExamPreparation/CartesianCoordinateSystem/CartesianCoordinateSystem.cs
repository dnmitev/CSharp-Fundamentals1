/* link to BgCoder Contest:
 * http://bgcoder.com/Contest/Practice/5 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main()
        {
            //input X and Y coordinates from the console
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());

            //check in which quadrant the point(X,Y) lies
            if (xCoordinate != 0 && yCoordinate != 0)
            {
                if (xCoordinate > 0)
                {
                    if (yCoordinate > 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("4");
                    }
                }
                else if (yCoordinate > 0)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("3");
                }
            }
            else if (xCoordinate == 0 && yCoordinate != 0)
            {
                Console.WriteLine("5");
            }
            else if (xCoordinate != 0 && yCoordinate == 0)
            {
                Console.WriteLine("6");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
