//11.* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.

//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).

//Implement collision detection and scoring system.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

struct Rock
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

struct Dwarf
{
    public int x;
    public int y;
    public string symbol;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Red)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Magenta)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        int playfieldWidth = 100;
        int livesCount = 5;
        int points = 0;
        char[] typeRock = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 100;

        Dwarf myDwarf = new Dwarf();
        myDwarf.x = 49;
        myDwarf.y = 39;
        myDwarf.symbol = "(0)";
        myDwarf.color = ConsoleColor.Green;

        Random randomGenerator = new Random();

        List<Rock> rocks = new List<Rock>();

        while (true)
        {
            bool hitted = false;

            // Create a new rock on the console
            {
                Rock newRock = new Rock();
                foreach (string colorName in colorNames)
                {
                    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                    if (color == ConsoleColor.Black)
                    {
                        continue; //skip black colored rocks
                    }
                    newRock.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[randomGenerator.Next(0,16)]); //random color rock 
                }
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 4;
                newRock.c = new string(typeRock[randomGenerator.Next(0, 11)],randomGenerator.Next(0,5));
                rocks.Add(newRock);
            }

            // Move the dwarf with pressed Arrow key
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true); // The dwarf moves without lag left and right.
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (myDwarf.x - 1 >= 0)
                    {
                        myDwarf.x = myDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (myDwarf.x + 1 <= playfieldWidth)
                    {
                        myDwarf.x = myDwarf.x + 1;
                    }
                }
            }

            // Move the falling rocks
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                for (int j = 0; j < newRock.c.Length; j++)
                {
                    if ((newRock.y == myDwarf.y) && (((newRock.x + j) == myDwarf.x) || ((newRock.x + j) == myDwarf.x + 1) || ((newRock.x + j) == myDwarf.x + 2)))
                    {
                        hitted = true;
                        livesCount--;   // Check if a falling rock has hitten the dwarf
                        points -= 50;   //-50p. penalty for being hitted
                        if (livesCount <= 0)
                        {
                            PrintStringOnPosition(35, 20, "GAME OVER!!!", ConsoleColor.Red);
                            PrintStringOnPosition(35, 22, "Your score: " + points, ConsoleColor.Red);
                            PrintStringOnPosition(35, 24, "Pres [enter] to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;

            // Clear the console
            Console.Clear();

            // Redraw playfield
            PrintStringOnPosition(myDwarf.x, myDwarf.y, myDwarf.symbol, myDwarf.color);
            foreach (Rock rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
            }
            if (hitted)
            {
                rocks.Clear();
                PrintOnPosition(myDwarf.x + 1, myDwarf.y, "X", ConsoleColor.Red);
            }
            else
            {
                // Score system due to the time played
                if (randomGenerator.Next(0,100) > 95)
                {
                    points += 15;
                }
                else if (randomGenerator.Next(0,100) > 75)
                {
                    points += 5;
                }
                if (points % 50 == 0)
                {
                    points += 10; // 10p. bonus on every 50 points made
                }
                PrintStringOnPosition(myDwarf.x, myDwarf.y, myDwarf.symbol, myDwarf.color);
            }

            // Draw game info
            PrintStringOnPosition(0, 0, "".PadLeft(100,'='), ConsoleColor.Green);
            PrintStringOnPosition(1, 1, "FALLING ROCKS", ConsoleColor.Green);
            PrintStringOnPosition(1, 2, "Keep the poor dwarf off the falling rocks", ConsoleColor.White);
            PrintStringOnPosition(1, 3, "Hint: Move your dwarf using left and right arrow key on your keyboard", ConsoleColor.White);
            PrintStringOnPosition(85, 1, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(85, 2, "Score: " + points, ConsoleColor.White);
            PrintStringOnPosition(0, 4, "".PadLeft(100, '='), ConsoleColor.Green);

            // Slow down program execution
            Thread.Sleep(150);
        }
    }
} 