/*Link to BgCoder
 * http://bgcoder.com/Contest/Practice/131 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    class CoffeeVendingMachine //done at the academy
    {
        static void Main(string[] args)
        {
            //input the amount of coins using the keyboard
            int countOf5Coins = int.Parse(Console.ReadLine());
            int countOf10Coins = int.Parse(Console.ReadLine());
            int countOf20Coins = int.Parse(Console.ReadLine());
            int countOf50Coins = int.Parse(Console.ReadLine());
            int countOf100Coins = int.Parse(Console.ReadLine());

            //input the amount of given money and the price
            //NOTE!!!! REMEMBER USING decimal type for money!!!!!!!!!
            decimal inputMoney = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal changeMoney = inputMoney - price; //calculate the needed change

            if (changeMoney < 0)
            {
                Console.WriteLine("More {0:F2}", -changeMoney);
            }
            else
            {
                decimal machineMoney = 
                    0.05M * countOf5Coins +
                    0.10M * countOf10Coins +
                    0.20M * countOf20Coins +
                    0.50M * countOf50Coins +
                    1.00M * countOf100Coins;
                if (machineMoney >= changeMoney)
                {
                    Console.WriteLine("Yes {0:F2}", machineMoney - changeMoney);
                    
                }
                else
                {
                    Console.WriteLine("No {0:F2}", changeMoney - machineMoney);
                }
            }
        }
    }
}
