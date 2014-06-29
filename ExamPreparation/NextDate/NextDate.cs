/* Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/79 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());   //[1...31]
            int month = int.Parse(Console.ReadLine()); //[1...12]
            int year = int.Parse(Console.ReadLine());  //[2000....2013]

            switch (month)
            {
                case 1:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 2:
                    if (year % 4 == 0)
                    {
                        if (day < 29)
                        {
                            day++;
                        }
                        else
                        {
                            day = 1;
                            month++;
                        }
                    }
                    else
                    {
                        if (day < 28)
                        {
                            day++;
                        }
                        else
                        {
                            day = 1;
                            month++;
                        }
                    }
                    break;
                case 3:
                    if (day < 31 )
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 4:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 5:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 6:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 7:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 8:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 9:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 10:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                case 11:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                    break;
                default:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month = 1;
                        year++;
                    }
                    break;
            }

            Console.WriteLine("{0}.{1}.{2}", day, month, year);
        }
    }
}
