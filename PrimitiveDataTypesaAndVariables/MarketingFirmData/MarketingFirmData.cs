/*10. A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
 * first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names */

namespace MarketingFirmData
{
    using System;

    class MarketingFirmData
    {
        static void Main()
        {
            string firstName = "Pesho";
            string familyName = "Peshev";
            byte age = 42;
            char gender = 'm';
            string numberID = "32B16W";
            int uniqueEmplNum = 27560606;
            Console.WriteLine("RECORD ABOUT {0} {1} \n",firstName,familyName);
            Console.WriteLine("Name: {0} {1}",firstName,familyName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("ID Number: {0}",numberID);
            Console.WriteLine("Unique emploee number: {0}",uniqueEmplNum);

        }
    }
}
