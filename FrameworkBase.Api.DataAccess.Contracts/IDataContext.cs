using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts
{
    public interface IDataContext
    {
        DbSet<AdminEntity> Admins { get; set; }

        DbSet<BookingEntity> Bookings { get; set; }

        DbSet<OfficeEntity> Offices { get; set; }

        DbSet<Office2RoomsEntity> Office2Rooms { get; set; }

        DbSet<RoomEntity> Rooms { get; set; }

        DbSet<Room2ServiceEntity> Room2Services { get; set; }

        DbSet<UserEntity> Users { get; set; }

        DbSet<ServiceEntity> Services { get; set; }



        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        void RemoveRange(IEnumerable<object> entity);

        EntityEntry Update(object entity);

    }
}
