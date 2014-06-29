/*Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/133 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CardWarsBatka
{
    class CardWarsBatka
    {
        static void Main(string[] args)
        {
            //Define a constant for the count of cards in a hand
            const int cardsCount = 3;

            //console input of number of games
            int gamesCount = int.Parse(Console.ReadLine());

            //declare initial scores
            BigInteger playerOneLocalScore = 0;
            BigInteger playerOneGlobalScore = 0;
            BigInteger playerTwoLocalScore = 0;
            BigInteger playerTwoGlobalScore = 0;

            //declare games won by player
            int gamesWonPlayerOne = 0;
            int gamesWonPlayerTwo = 0;

            //declare flags for the X card
            bool xCardPlayerOne = false;
            bool xCardPlayerTwo = false;


            //input cards until games < gamesCount
            for (int games = 0; games < gamesCount; games++)
            {
                //Calculate Player One local score
                int counterOfPlayerOne = 1;
                while (counterOfPlayerOne <= cardsCount)
                {
                    string playerOneCardInput = Console.ReadLine();
                    switch (playerOneCardInput)
                    {
                        case "K":
                            playerOneLocalScore += 13;
                            break;
                        case "Q":
                            playerOneLocalScore += 12;
                            break;
                        case "J":
                            playerOneLocalScore += 11;
                            break;
                        case "A":
                            playerOneLocalScore += 1;
                            break;
                        case "Z":
                            playerOneGlobalScore *= 2;
                            break;
                        case "Y":
                            playerOneGlobalScore -= 200;
                            break;
                        case "X":
                            xCardPlayerOne = true;
                            break;
                        default:
                            playerOneLocalScore += (12 - int.Parse(playerOneCardInput));
                            break;
                    }
                    counterOfPlayerOne++;
                }


                //Calculate Player Two local score
                int counterOfPlayerTwo = 1;
                while (counterOfPlayerTwo <= cardsCount)
                {
                    string playerTwoCardInput = Console.ReadLine();
                    switch (playerTwoCardInput)
                    {
                        case "K":
                            playerTwoLocalScore += 13;
                            break;
                        case "Q":
                            playerTwoLocalScore += 12;
                            break;
                        case "J":
                            playerTwoLocalScore += 11;
                            break;
                        case "A":
                            playerTwoLocalScore += 1;
                            break;
                        case "Z":
                            playerTwoGlobalScore *= 2;
                            break;
                        case "Y":
                            playerTwoGlobalScore -= 200;
                            break;
                        case "X":
                            xCardPlayerTwo = true;
                            break;
                        default:
                            playerTwoLocalScore += (12 - int.Parse(playerTwoCardInput));
                            break;
                    }
                    counterOfPlayerTwo++;
                }

                //check for the X card being drawn
                if (xCardPlayerOne && xCardPlayerTwo)
                {
                    playerOneGlobalScore += 50;
                    playerTwoGlobalScore += 50;
                }
                else if (xCardPlayerOne)
                {
                    break;
                }
                else if (xCardPlayerTwo)
                {
                    break;
                }                   
            
                //check which player has greater local score and wins the game
                if (playerOneLocalScore > playerTwoLocalScore)
                {
                    playerOneGlobalScore += playerOneLocalScore;
                    gamesWonPlayerOne++;
                }
                else if (playerOneLocalScore < playerTwoLocalScore)
                {
                    playerTwoGlobalScore += playerTwoLocalScore;
                    gamesWonPlayerTwo++;
                }

                //reset hand strength
                playerOneLocalScore = 0;
                playerTwoLocalScore = 0;
                //reset X card drawn flags
                xCardPlayerOne = false;
                xCardPlayerTwo = false;
            }


            if (xCardPlayerOne)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
            }
            else if (xCardPlayerTwo)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
            }
            else if (playerOneGlobalScore > playerTwoGlobalScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", playerOneGlobalScore);
                Console.WriteLine("Games won: {0}", gamesWonPlayerOne);
            }
            else if (playerOneGlobalScore < playerTwoGlobalScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", playerTwoGlobalScore);
                Console.WriteLine("Games won: {0}", gamesWonPlayerTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", playerOneGlobalScore);
            }
        }
    }
}

