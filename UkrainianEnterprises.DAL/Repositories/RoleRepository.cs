using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UkrainianEnterprises.Common;
using UkrainianEnterprises.Common.Repositories;

namespace UkrainianEnterprises.DAL.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(EnterpriseContext context)
            : base(context)
        {
        }

        public Role FindByName(string roleName)
        {
            return Set.FirstOrDefault(x => x.Name == roleName);
        }

        public Task<Role> FindByNameAsync(string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName);
        }

        public Task<Role> FindByNameAsync(System.Threading.CancellationToken cancellationToken, string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName, cancellationToken);
        }
    }
}
