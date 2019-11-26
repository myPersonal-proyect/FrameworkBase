using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class ServiceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ServiceEntity> entityBuilder)
        {
            entityBuilder.ToTable("Services");

            entityBuilder.HasKey(x => x.ServiceId);
            entityBuilder.Property(x => x.ServiceId).IsRequired();

        }

    }
}
