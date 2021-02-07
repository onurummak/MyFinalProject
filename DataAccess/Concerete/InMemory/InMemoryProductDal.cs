using DataAccess.Abstract;
using DataAccess.Concerete.EntityFramework;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concerete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Category> _products;
        public InMemoryProductDal()  //constructor oluştu ürün oluşturma inşaatı
        {   // sanki veriler oracle sql server, postgres mongodb
            _products = new List<Category> { 
            new Category{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Category{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
            new Category{ProductId=3,CategoryId=1,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
            new Category{ProductId=4,CategoryId=1,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Category{ProductId=5,CategoryId=1,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

  
        public void Delete(Category product)
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
            Category productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //=>LAMBDA
            _products.Remove(productToDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _products;
        }

        public List<Category> GetAllByCategory(int CategoryId)
        {
           return _products.Where(p => p.CategoryId == CategoryId).ToList();
        }

        public void Update(Category product)
        {    //  gönderdiğim ürünün id sine sahip  olan listedeki ürünü bul
            Category productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //=>LAMBDA
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
    }
}
