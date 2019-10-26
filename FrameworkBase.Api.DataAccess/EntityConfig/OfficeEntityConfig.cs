using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {
            entityBuilder.ToTable("Office");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            entityBuilder.HasOne(x => x.Admin).WithOne(x => x.Office);
            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);
            entityBuilder.HasMany(x => x.Office2Rooms).WithOne(x => x.Office);

        }


    }
}
