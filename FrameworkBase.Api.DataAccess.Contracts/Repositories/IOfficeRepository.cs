using FrameworkBase.Api.DataAccess.Contracts.Entities;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts.Repositories
{
    public interface IOfficeRepository : IRepository<OfficeEntity>
    {

        Task<OfficeEntity> Update(OfficeEntity entity);


    }
}
