using System.Collections.Generic;
using System.Data.Entity;

namespace Wingtip_Toys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {

        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(c => context.Products.Add(c));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                 CategoryID = 1,
                 CategoryName = "Cars"
                },

                new Category
                {
                 CategoryID = 2,
                 CategoryName = "Planes"
                },

                new Category
                {
                 CategoryID = 3,
                 CategoryName = "Trucks"
                },

                new Category
                {
                 CategoryID = 4,
                 CategoryName = "Boats"
                },

                new Category
                {
                 CategoryID = 5,
                 CategoryName = "Rockets"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 2,
                  ProductName = "Old-time Car",
                  Description = "There is nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                  ImagePath = "carearly.png",
                  UnitPrice = 15.95,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 3,
                  ProductName = "Fast Car",
                  Description = "Yes this car is fast, but it also floats in water.",
                  ImagePath = "carfast.png",
                  UnitPrice = 32.99,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 4,
                  ProductName = "Super Fast Car",
                  Description = "Use this super fast car to entertain guests. Lights and doors work!",
                  ImagePath = "carfaster.png",
                  UnitPrice = 8.95,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },

                new Product
                {
                  ProductID = 1,
                  ProductName = "Convertible Car",
                  Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                "Power it up and let it go!",
                  ImagePath = "carconvert.png",
                  UnitPrice = 22.50,
                  CategoryID = 1
                },





            };

            return products;
        }

    }
}