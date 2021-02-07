using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepostoryBase<TEntity,TContext>:IEntityRepostory<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)  //object relation mapping
        {   // IDisposable pattern implementation of c sharp
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);  //referansı yakala
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                // 2 değişken var birisi  context birisi çalışacağı ortam
                // generic yapılarda sistem birbiri üzerine eklenebilir
            }

        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);  //referansı yakala
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);  //referansı yakala
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
