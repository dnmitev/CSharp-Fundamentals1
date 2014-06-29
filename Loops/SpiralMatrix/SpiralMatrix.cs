//14. Write a program that reads a positive integer number N (N < 20) from console and 
//outputs in the console the numbers 1 ... N numbers arranged as a spiral.
/*Example: N=4  1  2  3  4
 *             12 13 14  5
 *             11 16 15  6
 *             10  9  8  7  */

namespace SpiralMatrix
{
    using System;

    class SpiralMatrix
    {
        static void Main()
        {
            Console.SetWindowSize(100, 30);
            int n = 0;
            do
            {
                Console.Write("N = ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 20);

            int maxRows = n;
            int maxCols = n;
            int[,] matrix = new int[n, n];
            int currentRow = 0;
            int currentCol = 0;
            int maxValue = n * n;
            int counter = 1;

            while (counter <= maxValue)
            {
                for (int i = currentRow; i < maxCols; i++)
                {
                    if (counter <= maxValue)
                    {
                        matrix[currentRow, i] = counter;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                currentRow++;
                for (int i = currentRow; i < maxRows; i++)
                {
                    if (counter <= maxValue)
                    {
                        matrix[i, maxCols - 1] = counter;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                maxCols--;
                for (int i = maxCols; i > currentCol; i--)
                {
                    if (counter <= maxValue)
                    {
                        matrix[maxRows - 1, i - 1] = counter;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                maxRows--;
                for (int i = maxRows; i > currentRow; i--)
                {
                    if (counter <= maxValue)
                    {
                        matrix[i - 1, currentCol] = counter;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                currentCol++;
            }

            //Printing the matrix on the console
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("|{0,3}|", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}