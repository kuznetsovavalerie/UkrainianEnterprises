using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkrainianEnterprises.DAL;

namespace UkrainianEnterprises.BLL.Service
{
    public class ManagerBase<TEntity> where TEntity : class
    {
        protected Repository<TEntity> repository;

        public ManagerBase (Repository<TEntity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repository.Get();
        }

        public TEntity GetByID(int id)
        {
            return this.repository.GetByID(id);
        }

        public void Create(TEntity entity)
        {
            this.repository.Insert(entity);
        }

        public void Delete(int id)
        {
            this.repository.Delete(id);
        }
    }
}
