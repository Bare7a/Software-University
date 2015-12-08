using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class Program
    {
        static void Main()
        {
            Deposit depositAccount = new Deposit(Customer.Individual, 1200, 6.5m);
            Loan loanAccount = new Loan(Customer.Company, 20000, 4.5m);
            Mortage mortageAccount = new Mortage(Customer.Individual, 500, 8);

            depositAccount.DepositMoney(800);
            Console.WriteLine("Deposit account curent balance: {0:F2}", depositAccount.Balance);

            loanAccount.DepositMoney(1000);
            Console.WriteLine("Loan account current balance: {0:F2}", loanAccount.Balance);

            mortageAccount.DepositMoney(200);
            Console.WriteLine("Mortage account current balance: {0:F2}", mortageAccount.Balance);

            depositAccount.Widthdraw(600.50m);
            Console.WriteLine("Deposit account current balance: {0:F2}", depositAccount.Balance);

            Console.WriteLine("Deposit account interset for 7 months: {0:F2}", depositAccount.CalculateInterest(7));
            Console.WriteLine("Loan account interest for 3 months: {0:F2}", loanAccount.CalculateInterest(2));
            Console.WriteLine("Motage account interest for 7 months: {0:F2}", mortageAccount.CalculateInterest(7));

            Console.WriteLine();
            Console.WriteLine("Deposit account info: \n" + depositAccount);
            Console.WriteLine("Loan account info: \n" + loanAccount);
            Console.WriteLine("Mortage acount info: \n" + mortageAccount);
        }
    }
}
