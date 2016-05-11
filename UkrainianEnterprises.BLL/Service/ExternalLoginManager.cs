using UkrainianEnterprises.Common;
using UkrainianEnterprises.Common.Repositories;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class ExternalLoginManager : ManagerBase<ExternalLogin>
    {
        private new IExternalLoginRepository repository;

        public ExternalLoginManager(ExternalLoginRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public ExternalLogin GetByProviderAndKey(string loginProvider, string providerKey)
        {
            return repository.GetByProviderAndKey(loginProvider, providerKey);
        }
    }
}
