using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class AdminEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<AdminEntity> entityBuilder)
        {
            // ----------Table Admins ----------//
            entityBuilder.ToTable("Admins");

            //---------- Id requered -----------//
            entityBuilder.HasKey(x => x.AdminId);
            entityBuilder.Property(x => x.AdminId).IsRequired();
           

            // ---------- Relation ------------//
            entityBuilder.HasOne(x => x.Office).WithOne(o => o.Admin)
                .HasForeignKey<OfficeEntity>(o =>o.OfficeId);
         
        }
    }
}
