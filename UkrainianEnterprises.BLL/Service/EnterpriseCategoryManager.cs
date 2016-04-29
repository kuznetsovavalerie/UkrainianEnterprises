using System.Collections.Generic;
using System.Globalization;
using UkrainianEnterprises.Common;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class EnterpriseCategoryManager : ManagerBase<EnterpriseCategory>
    {
        public EnterpriseCategoryManager(Repository<EnterpriseCategory> repository) : base(repository) { }

        public IEnumerable<EnterpriseCategory> GetByTerm(string term)
        {
            var culture = new CultureInfo("uk-UA");
            var result = base.GetAll(e => (culture.CompareInfo.IndexOf(e.Title, term, CompareOptions.IgnoreCase) >= 0) || 
                (culture.CompareInfo.IndexOf(e.Description, term, CompareOptions.IgnoreCase) >= 0));

            return result;
        }
    }
}
