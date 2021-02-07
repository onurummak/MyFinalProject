﻿using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Category> GetAll();
        List<Category> GetAllByCategoryId(int id);

    }
}
