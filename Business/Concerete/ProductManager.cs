using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concerete.InMemory;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concerete
{
    public class ProductManager : IProductService
    {   //dependency injection
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları yazılacak yetkisi var mı if şöyle ise böyle ise
            // veri erişimi

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}