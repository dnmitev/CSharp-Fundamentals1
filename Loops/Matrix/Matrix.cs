//12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
/*     1  2  3   for n=3
       2  3  4
       3  4  5    */
namespace Matrix
{
    using System;

    class Matrix
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Please enter value for N: ");
                n = int.Parse(Console.ReadLine());
            } while ((n <= 0) || (n >= 20));            // be sure that entered N is within 0<N<20

            int number = 1;
            for (int col = 1; col <= n; col++)   //print the matrix on the console
            {
                number = col;
                for (int row = 1; row <= n; row++)
                {
                    Console.Write("{0,3}",number);
                    number++;
                }
                Console.WriteLine(); //place every new row on a new line
            }
        }
    }
}

