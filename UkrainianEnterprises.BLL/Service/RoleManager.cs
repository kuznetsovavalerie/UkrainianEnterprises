using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Common.Repositories;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class RoleManager : ManagerBase<Role>
    {
        private new IRoleRepository repository;

        public RoleManager(RoleRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public Role FindByName(string name)
        {
            return repository.FindByName(name);
        }
    }
}
