using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concerete.EntityFramework;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concerete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private EfCategoryDal efCategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CategoryManager(EfCategoryDal efCategoryDal)
        {
            this.efCategoryDal = efCategoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        //select * froum
        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetById(c => c.CategoryId == categoryId);
        }
    }
}
