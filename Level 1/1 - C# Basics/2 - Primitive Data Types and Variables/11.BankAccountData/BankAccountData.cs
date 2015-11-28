using System;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hristiyan";
            string middleName = "Boyanov";
            string lastName = "Mishinkov";
            int availableMoney = 5676977;
            string bankName = "Fulton Bank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            long creditCardNum1 = 4532850341826243;
            long creditCardNum2 = 4485588770299337;
            long creditCardNum3 = 4556666385744253;
            Console.WriteLine("Bank Name: {0} \t\t\t IBAN: {1}",bankName,iban);
            Console.WriteLine("Name: {0} {1} {2} \t Money: {3}", firstName,middleName,lastName,availableMoney);
            Console.WriteLine();
            Console.WriteLine("Credit Card 1 Number: {0}", creditCardNum1);
            Console.WriteLine("Credit Card 2 Number: {0}", creditCardNum2);
            Console.WriteLine("Credit Card 3 Number: {0}", creditCardNum3);

        }
    }
}
