

using ProductsShop.Data.Migrations;

namespace ProductsShop.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Models;

    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
            : base("ProductsShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductsShopContext,Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.ProductsBought)
                .WithOptional(p => p.Buyer)
                .Map(m =>
                {
                    m.MapKey("BuyerId");
                });

            modelBuilder.Entity<User>()
                .HasMany(u => u.ProductsSold)
                .WithRequired(p => p.Seller)
                .Map(m =>
                {
                    m.MapKey("SellerId");
                });

            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("FriendId");
                    m.ToTable("UserFriends");
                });
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}