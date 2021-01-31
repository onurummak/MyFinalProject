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
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları yazılacak yetkisi var mı if şöyle ise böyle ise
            // veri erişimi
           
            return _productDal.GetAll();  //sonuç işlem
        }
    }
}
