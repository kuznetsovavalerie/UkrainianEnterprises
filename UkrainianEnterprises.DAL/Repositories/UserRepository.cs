using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Common.Repositories;

namespace UkrainianEnterprises.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(EnterpriseContext context)
            : base(context)
        {
        }

        public User FindByUserName(string username)
        {
            return Set.FirstOrDefault(x => x.UserName == username);
        }

        public Task<User> FindByUserNameAsync(string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public Task<User> FindByUserNameAsync(System.Threading.CancellationToken cancellationToken, string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username, cancellationToken);
        }

        public User FindByEmail(string email)
        {
            return Set.FirstOrDefault(x => x.Email == email);
        }

        public Task<User> FindByEmailAsync(string email)
        {
            return Set.FirstOrDefaultAsync(x => x.Email == email);
        }

        public string GetEmail(Guid id)
        {
            return Set.FirstOrDefault(x => x.Id == id)?.Email;
        }

        public bool GetEmailConfirmed(Guid id)
        {
            return Set.FirstOrDefault(x => x.Id == id)?.EmailConfirmed ?? false;
        }
    }
}
