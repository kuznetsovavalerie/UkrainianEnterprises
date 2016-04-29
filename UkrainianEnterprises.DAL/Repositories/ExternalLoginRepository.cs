using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UkrainianEnterprises.Common;
using UkrainianEnterprises.Common.Repositories;

namespace UkrainianEnterprises.DAL.Repositories
{
    public class ExternalLoginRepository : Repository<ExternalLogin>, IExternalLoginRepository
    {
        public ExternalLoginRepository(EnterpriseContext context)
            : base(context)
        {
        }

        public ExternalLogin GetByProviderAndKey(string loginProvider, string providerKey)
        {
            return Set.FirstOrDefault(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey);
        }

        public Task<ExternalLogin> GetByProviderAndKeyAsync(string loginProvider, string providerKey)
        {
            return Set.FirstOrDefaultAsync(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey);
        }

        public Task<ExternalLogin> GetByProviderAndKeyAsync(CancellationToken cancellationToken, string loginProvider, string providerKey)
        {
            return Set.FirstOrDefaultAsync(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey, cancellationToken);
        }
    }
}
