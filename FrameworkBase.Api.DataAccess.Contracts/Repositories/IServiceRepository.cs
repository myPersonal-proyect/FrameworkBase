using FrameworkBase.Api.DataAccess.Contracts.Entities;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts.Repositories
{
    public interface IServiceRepository : IRepository<ServiceEntity>
    {
        Task<ServiceEntity> Update(ServiceEntity objectEntity);

    }
}
