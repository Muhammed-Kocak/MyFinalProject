using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity,new()
        where TContext: DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Referance Catch
                addedEntity.State = EntityState.Added; //Added
                context.SaveChanges(); //Save
            }
        }

        public void Delete(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //Referance Catch
                deletedEntity.State = EntityState.Deleted; //Deleted
                context.SaveChanges(); //Save
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
                //select * from products          //select * from product where filter
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Referance Catch
                updatedEntity.State = EntityState.Modified; //Modified
                context.SaveChanges(); //Save
            }
        }
    }
}
