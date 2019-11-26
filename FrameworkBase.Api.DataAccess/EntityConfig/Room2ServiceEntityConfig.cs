using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class Room2ServiceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Room2ServiceEntity> entityBuilder)
        {
            entityBuilder.ToTable("Room2Services");


            entityBuilder.HasOne(X => X.Room).WithMany(X => X.Room2ServiceEntity).HasForeignKey(X => X.RoomId);
            entityBuilder.HasOne(X => X.Service).WithMany(X => X.Room2ServiceEntity).HasForeignKey(X => X.ServiceId);

            entityBuilder.HasKey(x => new { x.RoomId, x.ServiceId });

            entityBuilder.Property(x => x.RoomId).IsRequired();
            entityBuilder.Property(x => x.ServiceId).IsRequired();
        }
    }
}
