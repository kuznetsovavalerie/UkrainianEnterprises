﻿using System.Threading;
using System.Threading.Tasks;

namespace UkrainianEnterprises.Common.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByUserName(string username);

        Task<User> FindByUserNameAsync(string username);

        Task<User> FindByUserNameAsync(CancellationToken cancellationToken, string username);
    }
}
