/*Link to BGCoder:
 * http://bgcoder.com/Contest/Practice/133 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretOfNumbers
{
    class SecretOfNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.TrimStart(new char[] { '0', '-' });
            int secretSum = 0;

            //Find the secret sum
            for (int i = 0; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                if ((input.Length - i) % 2 != 0)
                {
                    secretSum = secretSum + digit * (input.Length - i) * (input.Length - i);
                }
                else
                {
                    secretSum = secretSum + digit * digit * (input.Length - i);
                }
            }

            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            if (secretSum % 10 == 0)
            {
                Console.WriteLine(secretSum);
                Console.WriteLine("{0} has no secret alpha-sequence", input);
            }
            else
            {
                int mainCounter = 0;
                int counter = 0;
                int letterNumber = secretSum % 26;

                Console.WriteLine(secretSum);
                while (mainCounter < (secretSum % 10))
                {
                    if ((letterNumber + mainCounter) < alphabet.Length)
                    {
                        Console.Write(alphabet[letterNumber + mainCounter]);
                    }
                    else
                    {
                        Console.Write(alphabet[counter]);
                        counter++;
                    }
                    
                    mainCounter++;
                }
                Console.WriteLine();
            }
        }
    }
}
