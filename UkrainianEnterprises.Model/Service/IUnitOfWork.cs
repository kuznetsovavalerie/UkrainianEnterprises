using System.Threading.Tasks;
using UkrainianEnterprises.Common.Entities;

namespace UkrainianEnterprises.Common.Service
{
    public interface IUnitOfWork
    {
        void SaveChanges();

        Task SaveChangesAsync();
    }
}
