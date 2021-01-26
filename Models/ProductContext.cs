﻿using System.Data.Entity;

namespace Wingtip_Toys.Models
{
    public class ProductContext : DbContext
    {

        public ProductContext() : base("WingtipToys")
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }


    }
}