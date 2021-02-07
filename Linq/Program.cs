using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject  //Language integrated query
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar" },  //ilerleyen zamanda veri kaynağından gelecek
                new Category {CategoryId=2, CategoryName="Telefon"}    //şu anda bu simülasyon
            };
            List<Product> products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Acer Laptop",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{CategoryId=1,ProductId=1,ProductName="Asus Laptop",QuantityPerUnit="16 Gb Ram",UnitPrice=8000,UnitsInStock=3},
                new Product{CategoryId=1,ProductId=1,ProductName="Hp Laptop",QuantityPerUnit="8 Gb Ram",UnitPrice=6000,UnitsInStock=2},
                new Product{CategoryId=2,ProductId=1,ProductName="Samsung Telefon",QuantityPerUnit="4 Gb Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{CategoryId=2,ProductId=1,ProductName="Apple Telefon",QuantityPerUnit="4 Gb Ram",UnitPrice=8000,UnitsInStock=0},

            };
            
            
            Console.WriteLine("Linq ----------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProducts(products);

            static List<Product> GetProducts(List<Product> products)
            {
                List<Product> filteredProducts = new List<Product>();

                foreach (var product in products)
                {
                    if (product.UnitPrice > 5000 && product.UnitsInStock > 3)  //hem 5000 den büyük hem de 3ten fazla stok durumu olanları göster
                    {
                        filteredProducts.Add(product);
                    }

                }
                return filteredProducts;
            }
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    } 
}
