using DataAccess.Abstract;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concerete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()  //constructor oluştu ürün oluşturma inşaatı
        {   // sanki veriler oracle sql server, postgres mongodb
            _products = new List<Product> { 
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
            new Product{ProductId=3,CategoryId=1,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
            new Product{ProductId=4,CategoryId=1,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5,CategoryId=1,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {    // bu linksiz yazı şekli normalde link var onu kullanacağız
           // Product productToDelete = null; 
            //LINQ Language Integrated Query
           
            //foreach (var p in _products) //bu döngü dizileri dolanıyor
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
                // foreach ile döngü dolanmıştı single or default gelmesi için using linq load yaptık

            //    // her p için dolanıyır
                
            //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //=>LAMBDA
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
           return _products.Where(p => p.CategoryId == CategoryId).ToList();
        }

        public void Update(Product product)
        {    //  gönderdiğim ürünün id sine sahip  olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //=>LAMBDA
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
