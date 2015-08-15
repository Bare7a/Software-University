using NewsSystem.Data.Migrations;
using NewsSystem.Models;

namespace NewsSystem.Data
{
    using System.Data.Entity;

    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("NewsContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsContext,Configuration>());
        }

        public virtual DbSet<News> News { get; set; }
    }
}