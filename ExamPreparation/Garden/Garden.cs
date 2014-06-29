/*Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/133 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main()
        {
            //input 
            int tomatoSeedsAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberSeedsAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeedsAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotSeedsAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageSeedsAmount = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansSeedsAmount = int.Parse(Console.ReadLine());

            //seed prices
            decimal priceOfTomatoSeeds = 0.50M;
            decimal priceOfCucumberSeeds = 0.40M;
            decimal priceOfPotatoSeeds = 0.25M;
            decimal priceOfCarrotSeeds = 0.60M;
            decimal priceOfCabbageSeeds = 0.30M;
            decimal priceOfBeansSeeds = 0.40M;

            decimal totalCost =
                tomatoSeedsAmount * priceOfTomatoSeeds +
                cucumberSeedsAmount * priceOfCucumberSeeds +
                potatoSeedsAmount * priceOfPotatoSeeds +
                carrotSeedsAmount * priceOfCarrotSeeds +
                cabbageSeedsAmount * priceOfCabbageSeeds +
                beansSeedsAmount * priceOfBeansSeeds;

            int totalArea = 250;
            int vegetablesArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

            if (vegetablesArea > totalArea)
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("Insufficient area");
            }
            else
            {
                if (vegetablesArea < totalArea)
                {
                    Console.WriteLine("Total costs: {0:F2}", totalCost);
                    Console.WriteLine("Beans area: {0}", totalArea - vegetablesArea);
                }
                else
                {
                    Console.WriteLine("Total costs: {0:F2}", totalCost);
                    Console.WriteLine("No area for beans");
                }
            }
        }
    }
}
