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

            
            entityBuilder.HasOne(X => X.Room).WithMany(X => X.Room2ServiceEntity).HasForeignKey(X => X.IdRoom);
            entityBuilder.HasOne(X => X.Service).WithMany(X => X.Room2ServiceEntity).HasForeignKey(X => X.IdService);

            entityBuilder.HasKey(x => new { x.IdRoom, x.IdService });

            entityBuilder.Property(x => x.IdRoom).IsRequired();
            entityBuilder.Property(x => x.IdService).IsRequired();
        }
    }
}
