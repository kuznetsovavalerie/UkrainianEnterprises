using UkrainianEnterprises.Common;
using UkrainianEnterprises.Common.Repositories;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class UserManager : ManagerBase<User>
    {
        private new IUserRepository repository;

        public UserManager(UserRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public User FindByUserName(string name)
        {
            return repository.FindByUserName(name);
        }
    }
}
