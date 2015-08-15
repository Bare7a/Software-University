using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using ProductsShop.Data;
using Formatting = Newtonsoft.Json.Formatting;

namespace ProjectsShop.Console
{
    class QueryAndExportData
    {
        static void Main()
        {
            var context = new ProductsShopContext();
            //Problem 1. Get all products in a specified price range (500 to 1000) which have no buyer
            ProductsWithNoBuyerInRange(context, 500, 1000);
            //Problem 2. Successfully Sold Products
            SuccessfullySoldProducts(context);
            //Problem 3. Categories By Products Count
            CategoriesByProductsCount(context);
            //Problem 4. Users and Products
            UsersAndProducts(context);
        }

        private static void ProductsWithNoBuyerInRange(ProductsShopContext db, decimal minPrice, decimal maxPrice)
        {
            var products = db.Products
                .Where(p =>
                    p.Price >= minPrice &&
                    p.Price <= maxPrice &&
                    p.Buyer != null
                )
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    Seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(p => p.Price);
            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText("../../../products-in-range.json", json);
        }

        private static void SuccessfullySoldProducts(ProductsShopContext db)
        {
            var sellers = db.Users
                .Where(u => u.ProductsSold.Count >= 1)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    Product = u.ProductsSold.Select(p => new
                    {
                        p.Name,
                        p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Buyer.LastName
                    }).OrderBy(p => p.BuyerLastName).ThenBy(p => p.BuyerFirstName)
                });
            var json = JsonConvert.SerializeObject(sellers, Formatting.Indented);
            File.WriteAllText("../../../users-sold-productions.json", json);
        }
        private static void CategoriesByProductsCount(ProductsShopContext db)
        {
            var categories = db.Categories

                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.Products.Count,
                    AvaragePrice = c.Products.Average(p => p.Price),
                    TotalRevenue = c.Products.Sum(p => p.Price)
                }).OrderByDescending(c => c.ProductsCount);
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText("../../../categories-by-products.json", json);
        }

        private static void UsersAndProducts(ProductsShopContext db)
        {
            var users = db.Users
                .Where(u => u.ProductsSold.Count >= 1)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    u.Age,
                    Product = u.ProductsSold.Select(p => new
                    {
                        p.Name,
                        p.Price
                    })
                }).OrderByDescending(u => u.Product.Count()).ThenBy(u => u.LastName);
            
            XElement root = new XElement("users");
            root.SetAttributeValue("count", users.Count());
            foreach (var userNode in users)
            {
                var user = new XElement("user");
                if (userNode.FirstName != null)
                {
                    user.SetAttributeValue("first-name", userNode.FirstName);
                }
                if (userNode.LastName != null)
                {
                    user.SetAttributeValue("last-name", userNode.LastName);
                }
                if (userNode.Age != null)
                {
                    user.SetAttributeValue("age", userNode.Age);
                }
 
                var soldProducts = new XElement("sold-products");
                soldProducts.SetAttributeValue("count", userNode.Product.Count());
                foreach (var productNode in userNode.Product)
                {
                    var product = new XElement("product");
                    if (productNode.Name != null)
                    {
                        product.SetAttributeValue("name", productNode.Name);
                    }
                    if (productNode.Price != null)
                    {
                        product.SetAttributeValue("price", productNode.Price);
                    }
                    soldProducts.Add(product);
                }  
                user.Add(soldProducts);
                root.Add(user);
            }
 
            var xmlDoc = new XDocument(root);
            xmlDoc.Save("../../../users-and-product.xml");
            }
            
        }
    }


