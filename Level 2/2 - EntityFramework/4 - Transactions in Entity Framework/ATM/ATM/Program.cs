using System;
using System.Linq;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ATMEntities();
            var cardAccounts = db.CardAccounts;
            foreach (var cardAccount in cardAccounts)
            {
                Console.WriteLine(cardAccount.CardCash);
                WithdrawalMoney(cardAccount.CardNumber,cardAccount.CardPin, 2000);
            }
        }

        private static void WithdrawalMoney(string cardNumber, string cardPin, decimal amount)
        {
            var db = new ATMEntities();

            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    var account = db.CardAccounts
                        .FirstOrDefault(a => a.CardNumber == cardNumber);

                    if (account == null)
                    {
                        var messge = string.Format("Invalid card number: {0}", cardNumber);
                        throw new ArgumentException(messge);
                    }

                    if (account.CardPin!= cardPin)
                    {
                        var messge = string.Format("Invalid pin number: {0}", cardPin);
                        throw new ArgumentException(messge);
                    }

                    if (account.CardCash < amount)
                    {
                        var messge = string.Format("Not enough amount of money!\nAvailability: {0}", account.CardCash);
                        throw new ArgumentException(messge);
                    }

                    account.CardCash = account.CardCash - amount;
                    db.SaveChanges();
                    dbContextTransaction.Commit();
                    SaveTransactionHistory(cardNumber, amount);
                    Console.WriteLine("Withdrawal is successfull.\nRemaining amount: {0}", account.CardCash);
                }
                catch (ArgumentException ae)
                {

                    dbContextTransaction.Rollback();
                    Console.WriteLine("Error: " + ae.Message);
                }
            }
        }
        private static void SaveTransactionHistory(string cardNumber, decimal amount)
        {
            var db = new ATMEntities();

            var newTransaction = new TransactionHistory()
            {
                CardNumber = cardNumber,
                TransactionDate = DateTime.Now,
                Amount = amount
            };

            db.TransactionHistories.Add(newTransaction);
            db.SaveChanges();
        }
    }
}
