using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concerete.EntityFramework
{
    public class EfOrderDal:EfEntityRepostoryBase<Order,NorthwindContext>,IOrderDal
    {

    }
}
