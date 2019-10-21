using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace FrameworkBase.Api.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions options) : base(options) { }
       

        public DbSet<AdminEntity> Admins { get; set; }
      
        public DbSet<BookingEntity> Bookings { get; set; }
        
        public DbSet<OfficeEntity> Offices { get; set; }
        
        public DbSet<Office2RoomsEntity> Office2Rooms { get; set; }
        
        public DbSet<RoomEntity> Rooms { get; set; }
        
        public DbSet<Room2ServiceEntity> Room2Services { get; set; }
        
        public DbSet<UserEntity> Users { get; set; }
        
        public DbSet<ServiceEntity> Services { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());

            //BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());

            //OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficeEntity>());

            //Office2RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<Office2RoomsEntity>());

            //RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());

            //Room2ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room2ServiceEntity>());

            //UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());

            //ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServiceEntity>());



            base.OnModelCreating(modelBuilder);
        }


    }
}
