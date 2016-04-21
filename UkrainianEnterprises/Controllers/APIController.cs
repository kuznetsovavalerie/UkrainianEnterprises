using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.Common;

namespace UkrainianEnterprises.Controllers
{
    public class APIController : ApiController
    {
        /// <summary>
        /// Searches the enterprise categories by typed term.
        /// </summary>
        /// <param name="term">The term.</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<EnterpriseCategory> SearchCategories(string term)
        {
            IEnumerable<EnterpriseCategory> categories;

            using (var unitOfWork = new UnitOfWork())
            {
                categories = unitOfWork.EnterpriseCategoryManager.GetByTerm(term);
            }

            return categories;
        }
    }
}
