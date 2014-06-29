/*Link to BgCoder
 * http://bgcoder.com/Contest/Practice/131 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class BullsAndCows
    {
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            bool solutionFound = false;

            //go through all four digit numbers
            for (int number = 1000; number < 10000; number++)
            {
                int bullsCount = 0;
                int cowsCount = 0;

                char[] digits = number.ToString().ToCharArray();
                char[] secretNumber = inputNumber.ToCharArray();

                if (digits[0] >= '1' && digits[1] >= '1' && digits[2] >= '1' && digits[3] >= '1')
                {
                    //count the bulls and mark them as unavailable
                    for (int i = 0; i < secretNumber.Length; i++)
                    {
                        if (secretNumber[i] == digits[i])
                        {
                            bullsCount++;
                            secretNumber[i] = '*'; //assign symbol different than a digit
                            digits[i] = '@'; //assign symbol different than a digit
                        }
                    }

                    //count the cows and mark them as unavailable
                    for (int k = 0; k < secretNumber.Length; k++)
                    {
                        for (int j = 0; j < digits.Length; j++)
                        {
                            if (secretNumber[k] == digits[j])
                            {
                                cowsCount++;
                                secretNumber[k] = '*'; //assign symbol different than a digit
                                digits[j] = '@'; //assign symbol different than a digit
                            }
                        }
                    }


                    if (bullsCount == bulls && cowsCount == cows)
                    {
                        Console.Write("{0} ", number);
                        solutionFound = true;
                    }
                }
            }

            //check whether there is a solution or not
            if (!solutionFound)
            {
                Console.Write("No");
            }
        }
    }
}
