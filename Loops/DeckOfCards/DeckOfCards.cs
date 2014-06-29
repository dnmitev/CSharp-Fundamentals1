//11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

namespace DeckOfCards
{
    using System;

    class DeckOfCards
    {
        static void Main()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string color = "";

                    switch (j)   // look up the type of card suit
                    {
                        case 0:
                            color = "Clubs";
                            break;
                        case 1:
                            color = "Diamonds";
                            break;
                        case 2:
                            color = "Spades";
                            break;
                        case 3:
                            color = "Hearts";
                            break;
                        default:
                            Console.WriteLine("Check for mistakes!");
                            break;
                    }

                    switch (i)  // look up the different playing cards plus their suits
                    {
                        case 0: 
                            Console.WriteLine("Two of {0}",color);
                            break;
                        case 1: 
                            Console.WriteLine("Three of {0}",color);
                            break;
                        case 2:
                            Console.WriteLine("Four of {0}", color);
                            break;
                        case 3:
                            Console.WriteLine("Five of {0}", color);
                            break;
                        case 4:
                            Console.WriteLine("Six of {0}", color);
                            break;
                        case 5:
                            Console.WriteLine("Seven of {0}", color);
                            break;
                        case 6:
                            Console.WriteLine("Eight of {0}", color);
                            break;
                        case 7:
                            Console.WriteLine("Nine of {0}", color);
                            break;
                        case 8:
                            Console.WriteLine("Ten of {0}", color);
                            break;
                        case 9:
                            Console.WriteLine("King of {0}", color);
                            break;
                        case 10:
                            Console.WriteLine("Queen of {0}", color);
                            break;
                        case 11:
                            Console.WriteLine("Jack of {0}", color);
                            break;
                        case 12:
                            Console.WriteLine("Ace of {0}", color);
                            break;
                        default:
                            Console.WriteLine("Joker of {0}",color);
                            break;
                    }
                }
            }
        }
    }
}
