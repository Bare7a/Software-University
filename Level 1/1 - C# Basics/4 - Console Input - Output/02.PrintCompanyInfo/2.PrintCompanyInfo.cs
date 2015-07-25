using System;

namespace PrintCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Website: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string manFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string manLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int manAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string manPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Adress: {0}",companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: {0}",faxNumber);
            Console.WriteLine("Website: {0}",website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFirstName, manLastName, manAge, manPhone);
        }
    }
}
