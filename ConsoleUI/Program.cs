using Business.Concerete;
using DataAccess.Concerete.EntityFramework;
using DataAccess.Concerete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ProductTest();
            // Data Transformation Object
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
