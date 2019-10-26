using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrameworkBase.Api.DataAccess.Contracts
{
    public interface IDataContext
    {
        //DbSet<AdminEntity> Admins { get; set; }

        DbSet<BookingEntity> Bookings { get; set; }

        //DbSet<OfficeEntity> Offices { get; set; }

        //DbSet<Office2RoomsEntity> Office2Rooms { get; set; }

        //DbSet<RoomEntity> Rooms { get; set; }

        //DbSet<Room2ServiceEntity> Room2Services { get; set; }

        DbSet<UserEntity> Users { get; set; }

        //DbSet<ServiceEntity> Services { get; set; }


    }
}
