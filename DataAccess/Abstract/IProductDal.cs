using Core.DataAccess;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepostory<Product>
    {
        //ürüne ait özel operasyonların konulduğu yer olacak
        //ürün ve kategoriye join atmak


    }
}

//CODE REFACTORING YAPTIK KODU İYİLEŞTİRDİK
