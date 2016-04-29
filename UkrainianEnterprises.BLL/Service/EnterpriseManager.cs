﻿using UkrainianEnterprises.Common;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL.Service
{
    public class EnterpriseManager : ManagerBase<Enterprise>
    {
        public EnterpriseManager(Repository<Enterprise> repository) : base(repository)
        {
        }
    }
}
