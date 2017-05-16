using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//entity framework: query, insert, update, delete data

namespace ShoppingSite.Models
{
    //class represents entity framework product database context
    //derives from DbContext base class provided by Entity Framework
    /**********************************************
     * context class manages the entity classes
     * (product, category) and provides data access
     * to the database.
     *********************************************/
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ShoppingSite")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}