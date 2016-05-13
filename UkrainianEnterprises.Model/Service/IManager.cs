using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace UkrainianEnterprises.Common.Service
{
    public interface IManager<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        
        TEntity GetByID(int id);

        TEntity GetByID(Guid id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);

        void Delete(TEntity entity);
    }
}
