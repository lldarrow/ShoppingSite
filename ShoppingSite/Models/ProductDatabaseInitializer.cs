using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace ShoppingSite.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            //shopping categories for the store
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Flavors"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Merchandise"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Vanilla",
                    Description = "Vanilla. The quintessential classic ice cream flavor.",
                    ImagePath="Vanilla.png",
                    UnitPrice = 5.49,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Chocolate",
                    Description = "Made from the finest South American cocoa beans.",
                    ImagePath="Chocolate.png",
                    UnitPrice = 5.49,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Strawberry",
                    Description = "Tastes like... Strawberries. What did you expect?",
                    ImagePath="Strawberry.png",
                    UnitPrice = 5.49,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Neapolitan",
                    Description = "Strawberry, vanilla, and chocolate all in one container. Of course it's partitioned. You didn't think we'd just mix them together did you?",
                    ImagePath="Neapolitan.png",
                    UnitPrice = 6.49,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Pistacchio",
                    Description = "Limited Edition Flavor. Pistacchio ice cream made with real pistacchios.",
                    ImagePath="Pistacchio.png",
                    UnitPrice = 6.49,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Baseball Hat",
                    Description = "Baseball hat with Luke\'s Ice Cream logo.",
                    ImagePath="Hat.png",
                    UnitPrice = 9.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "T-Shirt",
                    Description = "Why are they called T-Shirts? We don't know but we put our logo on one.",
                    ImagePath="Shirt.png",
                    UnitPrice = 14.99,
                    CategoryID = 2
                }
            };

            return products;
        }
    }
}