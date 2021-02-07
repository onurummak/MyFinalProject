using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{       //generic constraint
             // class: referans tip olabilir demek class olabilir demek değil
                    // IEntity olabilir veya IEntity implemente eden bir nesne olabilir
                        //new() lenebilir olmalı+
                        //CORE KATMANI ASLA DİĞER KATMANLARI REFERANS ALMAAAAAZ!!! JOKER KATMAN
    public interface IEntityRepostory<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
