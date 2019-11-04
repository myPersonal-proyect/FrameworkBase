using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {
            entityBuilder.ToTable("Offices");

            entityBuilder.HasKey(x => x.OfficeId);
            entityBuilder.Property(x => x.OfficeId).IsRequired();

            entityBuilder.HasOne(x => x.Admin).WithOne(y => y.Office)
            .HasForeignKey<AdminEntity>(y => y.AdminId);

            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);
            entityBuilder.HasMany(x => x.Office2Rooms).WithOne(x => x.Office);

        }


    }
}
