//3. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

namespace CompanyAndMangarerInfo
{
    using System;

    class CompanyAndMangarerInfo
    {
        static void Main()
        {
            Console.Write("Please enter company's name: ");
            string companyName = Console.ReadLine();
            Console.Write("Please enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please enter company's phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Please enter company's fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Please enter company's web site: ");
            string companyWeb = Console.ReadLine();
            Console.Write("Please enter company's manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please enter company's manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Please enter manager's age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Please enter manager's phone number: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("".PadLeft(70, '='));
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("".PadLeft(70, '='));
            Console.WriteLine("Adress: {0}", companyAddress);
            Console.WriteLine("Phone: {0}", companyPhone);
            Console.WriteLine("Fax: {0}", companyFax);
            Console.WriteLine("Web-site: {0}", companyWeb);
            Console.WriteLine("".PadLeft(70, '='));
            Console.WriteLine("{0}'s manager:", companyName);
            Console.WriteLine("".PadLeft(70, '='));
            Console.WriteLine("First name: {0}", managerFirstName);
            Console.WriteLine("Last name: {0}", managerLastName);
            Console.WriteLine("Age: {0}", managerAge);
            Console.WriteLine("Phone: {0}", managerPhone);
        }
    }
}
