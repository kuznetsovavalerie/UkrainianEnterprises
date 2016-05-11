using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class ManagerBase<TEntity> where TEntity : class
    {
        protected Repository<TEntity> repository;

        public ManagerBase (Repository<TEntity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            return this.repository.Get(filter, orderBy, includeProperties);
        }

        public TEntity GetByID(int id)
        {
            return this.repository.GetByID(id);
        }

        public TEntity GetByID(Guid id)
        {
            return this.repository.GetByID(id);
        }

        public void Create(TEntity entity)
        {
            this.repository.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            this.repository.Update(entity);
        }

        public void Delete(int id)
        {
            this.repository.Delete(id);
        }

        public void Delete(TEntity entity)
        {
            this.repository.Delete(entity);
        }
    }
}
