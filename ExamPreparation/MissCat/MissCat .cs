/* link to BgCoder Contest:
 * http://bgcoder.com/Contest/Practice/5 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the number of jury members
            int juryMembers = int.Parse(Console.ReadLine());

            int[] juryVotes = new int[juryMembers];

            //input cat voted for
            for (int member = 0; member < juryMembers; member++)
            {
                juryVotes[member] = int.Parse(Console.ReadLine());
            }

            //initialize counters for each cat vote
            int[] cat = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //count the votes
            for (int member = 0; member < juryMembers; member++)
            {
                switch (juryVotes[member])
                {
                    case 1:
                        cat[0]++;
                        break;
                    case 2:
                        cat[1]++;
                        break;
                    case 3:
                        cat[2]++;
                        break;
                    case 4:
                        cat[3]++;
                        break;
                    case 5:
                        cat[4]++;
                        break;
                    case 6:
                        cat[5]++;
                        break;
                    case 7:
                        cat[6]++;
                        break;
                    case 8:
                        cat[7]++;
                        break;
                    case 9:
                        cat[8]++;
                        break;
                    default:
                        cat[9]++;
                        break;
                }
            }

            //find the winning cat
            int winPoints = cat[0];
            int winner = 1;

            for (int i = 1; i < cat.Length; i++)
            {
                if (cat[i] > winPoints)
                {
                    winPoints = cat[i];
                    winner = i + 1;
                }
            }

            //chech whether there isn't another cat with equal points to win
            int countOfWinners = 0;

            for (int i = 0; i < cat.Length; i++)
            {
                if (cat[i] == winPoints)
                {
                    countOfWinners++;
                }
            }

            //print out the winning cat
            for (int i = 0; i < cat.Length; i++)
            {
                if (countOfWinners == 1)
                {
                    Console.WriteLine(winner);
                    break;
                }
                else if (cat[i] == winPoints)
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }
    }
}
