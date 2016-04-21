using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkrainianEnterprises.DAL;
using UkrainianEnterprises.Common;

namespace UkrainianEnterprises.BLL.Service
{
    public class EnterpriseManager : ManagerBase<Enterprise>
    {
        public EnterpriseManager(Repository<Enterprise> repository) : base(repository)
        {
        }
    }
}
