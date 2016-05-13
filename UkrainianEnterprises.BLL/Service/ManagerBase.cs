using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UkrainianEnterprises.Common.Service;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    /// <summary>
    /// Base entity functionality
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class ManagerBase<TEntity> : IManager<TEntity> where TEntity : class
    {
        protected Repository<TEntity> repository;

        public ManagerBase (Repository<TEntity> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all entities by search criteria.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            return this.repository.Get(filter, orderBy, includeProperties);
        }

        /// <summary>
        /// Gets the Entity by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetByID(int id)
        {
            return this.repository.GetByID(id);
        }

        /// <summary>
        /// Gets Entity the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetByID(Guid id)
        {
            return this.repository.GetByID(id);
        }


        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Create(TEntity entity)
        {
            this.repository.Insert(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TEntity entity)
        {
            this.repository.Update(entity);
        }

        /// <summary>
        /// Deletes entity on the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            this.repository.Delete(id);
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Delete(TEntity entity)
        {
            this.repository.Delete(entity);
        }
    }
}
