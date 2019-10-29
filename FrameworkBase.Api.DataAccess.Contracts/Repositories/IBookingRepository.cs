using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public interface IBookingRepository : IRepository<BookingEntity>
    {
        Task<BookingEntity> Update(BookingEntity entity);

    }
}
