using System.Threading;
using System.Threading.Tasks;
using UkrainianEnterprises.Common.Entities;

namespace UkrainianEnterprises.Common.Repositories
{
    public interface IExternalLoginRepository : IRepository<ExternalLogin>
    {
        ExternalLogin GetByProviderAndKey(string loginProvider, string providerKey);

        Task<ExternalLogin> GetByProviderAndKeyAsync(string loginProvider, string providerKey);

        Task<ExternalLogin> GetByProviderAndKeyAsync(CancellationToken cancellationToken, string loginProvider, string providerKey);
    }
}
