using NewsSystem.Models;

namespace NewsSystem.Data.Migrations
{
    using System.Linq;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsSystem.Data.NewsContext context)
        {
            if (context.News.Any())
            {
                return;
            }

            var newsOne = new News()
            {
                Content = "Researching Marijuana for Therapeutic Purposes: The Potential Promise of Cannabidiol (CBD)"
            };
			
			var newsTwo = new News()
            {
                Content = "Media Coverage of Donald Trump Will Create Temporal Stupid Loop That Could Destroy Earth"
            };
			
			var newsThree = new News()
            {
                Content = "While Hillary Conditions, Bernie Engages. Guess Who's Rising?"
            };
			
            context.News.Add(newsOne);
			context.News.Add(newsTwo);
			context.News.Add(newsThree);
            context.SaveChanges();
        }
    }
}
