//9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

namespace SubsetSum
{
    using System;

    class SubsetSum
    {
        static void Main()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a value: ");
                array[i] = int.Parse(Console.ReadLine());
            } //input the values as an array

            int sum = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (sum == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2}", array[i], array[j], sum);
                        counter++;
                    }
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        sum = sum + array[k];
                        if (sum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", array[i], array[j], array[k], sum);
                            counter++;
                        }
                        for (int l = k + 1; l < array.Length; l++)
                        {
                            sum = sum + array[l];
                            if (sum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", array[i], array[j], array[k], array[l], sum);
                                counter++;
                            }
                            for (int m = l + 1; m < array.Length; m++)
                            {
                                sum = sum + array[l];
                                if (sum == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", array[i], array[j], array[k], array[l], sum);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("The count of subsets that equals zero is {0}", counter);
        }
    }
}



