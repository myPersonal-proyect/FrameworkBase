using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public interface IAdminRepository : IRepository<AdminEntity>
    {

        Task<AdminEntity> Update(int id, AdminEntity updateEntity);

    }
}
