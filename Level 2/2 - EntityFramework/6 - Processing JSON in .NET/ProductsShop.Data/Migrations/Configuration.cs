
namespace ProductsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Models;


    internal sealed class Configuration : DbMigrationsConfiguration<ProductsShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ProductsShopContext context)
        {
            var db = new ProductsShopContext();
            if (!db.Users.Any())
            {
                SeedUsers(db);
                SeedCategories(db);
                SeedProducts(db);
            }
        }
        private static void SeedUsers(ProductsShopContext context)
        {
            var xmlElement = XElement.Load("../../../users.xml").Elements();

            foreach (var xElement in xmlElement)
            {
                var user = new User();
                var firstName = xElement.Attribute("first-name");
                if (firstName != null)
                {
                    user.FirstName = firstName.Value;
                }

                var lastName = xElement.Attribute("last-name").Value;
                user.LastName = lastName;

                var age = xElement.Attribute("age");
                if (age != null)
                {
                    user.Age = int.Parse(age.Value);
                }

                context.Users.AddOrUpdate(user);
                context.SaveChanges();
            }
        }
        private static void SeedCategories(ProductsShopContext context)
        {
            using (StreamReader file = File.OpenText("../../../categories.json"))
            {
                Category[] categories = JsonConvert.DeserializeObject<Category[]>(file.ReadToEnd());

                foreach (var category in categories)
                {
                    context.Categories.AddOrUpdate(category);
                }

                context.SaveChanges();
            }
        }
        private static void SeedProducts(ProductsShopContext context)
        {
            var json = File.ReadAllText("../../../products.json");
            var products = JsonConvert.DeserializeObject<Product[]>(json);
            var categoryIds = context.Categories.Count()+1;
            var usersIds = context.Users.Count()+1;
            var rnd = new Random();

            foreach (var product in products)
            {
                var sellerId = rnd.Next(1, usersIds);
                var buyerId = rnd.Next(1, usersIds);
                var categoryId = rnd.Next(1, categoryIds);
                var seller = context.Users.Find(sellerId);
                var buyer = context.Users.Find(buyerId);
                var category = context.Categories.Find(categoryId);
                var currProduct = new Product()
                {
                    Seller = seller,
                    Name = product.Name,
                    Price = product.Price,
                    Categories = new List<Category>()
                    {
                        category
                    }
                };

                if (rnd.Next(0, 10) != 0)
                {
                    currProduct.Buyer = buyer;
                }

                context.Products.AddOrUpdate(currProduct);
            }

            context.SaveChanges();
        }
    }
}
