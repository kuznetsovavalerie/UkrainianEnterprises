using System;
using System.Threading.Tasks;
using UkrainianEnterprises.Common.Entities;
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

        public User FindByEmail(string email)
        {
            return repository.FindByEmail(email);
        }

        public string GetEmail(Guid id)
        {
            return repository.GetEmail(id);
        }

        public bool GetEmailConfirmed(Guid id)
        {
            return repository.GetEmailConfirmed(id);
        }
    }
}
