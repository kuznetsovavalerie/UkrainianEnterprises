using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace UkrainianEnterprises.DAL.Repositories
{
    public class Repository<TEntity> : IDisposable where TEntity : class
    {
        protected EnterpriseContext context;
        protected DbSet<TEntity> dbSet;

        public Repository(EnterpriseContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        protected DbSet<TEntity> Set
        {
            get
            {
                return dbSet;
            }
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = Set;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetByID(object id)
        {
            return Set.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            Set.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = Set.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                Set.Attach(entityToDelete);
            }

            Set.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            Set.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
