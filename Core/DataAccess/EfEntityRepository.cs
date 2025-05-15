using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntityRepository<TContext, TEntity> : IEntityRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var entityToRemove = context.Entry(entity);
                entityToRemove.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        { 
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
