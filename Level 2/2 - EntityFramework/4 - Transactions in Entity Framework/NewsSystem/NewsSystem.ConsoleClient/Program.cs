using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using NewsSystem.Data;
using NewsSystem.Data.Migrations;

namespace NewsSystem.ConsoleClient
{
    public class Program
    {
        static void Main()
        {
            ReadAndEditFirstNews();
        }

        private static void ReadAndEditFirstNews()
        {
            var db1 = new NewsContext();
            var firstNews = db1.News.First();
            firstNews.Content = Console.ReadLine();

            var db2 = new NewsContext();
            var secondNews = db2.News.First();
            secondNews.Content = Console.ReadLine();

            Console.WriteLine("First news content:");
            Console.WriteLine(firstNews.Content);

            Console.WriteLine("Second news content:");
            Console.WriteLine(secondNews.Content);

            db1.SaveChanges();
            try
            {
                db2.SaveChanges();
                Console.WriteLine("Changes successfully saved in the DB.");
            }
            catch (DbUpdateConcurrencyException)
            {

                Console.WriteLine("Conflict! The content is already changed.");
            }
        }
    }
}
