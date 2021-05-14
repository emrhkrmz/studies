using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=7000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=8000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Apple Telephone",QuantityPerUnit="2 GB RAM",UnitPrice=9000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Android Telephone",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitsInStock=0}

            };

            //NoLinq(products);

            Linq(products);

        }

        private static void Linq(List<Product> products)
        {
            //List<Product> result ... da diyebilirdik
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            //Where : Koşul anlamına gelir.
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        private static void NoLinq(List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
