using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class Office2RoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Office2RoomsEntity> entityBuilder)
        {
            entityBuilder.ToTable("Office2Room");


            entityBuilder.HasOne(X => X.Office).WithMany(X => X.Office2Rooms).HasForeignKey(X => X.OfficeId);
            entityBuilder.HasOne(X => X.Room).WithMany(X => X.Office2Rooms).HasForeignKey(X => X.RoomId);

            entityBuilder.HasKey(x => new { x.OfficeId, x.RoomId });
            entityBuilder.Property(x => x.OfficeId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();
        }
    }
}
