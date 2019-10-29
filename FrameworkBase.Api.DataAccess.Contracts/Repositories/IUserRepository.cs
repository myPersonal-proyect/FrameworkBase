using FrameworkBase.Api.DataAccess.Contracts.Entities;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> Update(UserEntity objectEntity);

    }
}
