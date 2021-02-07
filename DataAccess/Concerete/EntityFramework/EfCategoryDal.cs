using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concerete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepostoryBase<Category, NorthwindContext>
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
