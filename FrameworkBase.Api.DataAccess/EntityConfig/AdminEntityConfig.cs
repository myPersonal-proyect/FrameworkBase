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
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            // ---------- Relation ------------//
            entityBuilder.HasOne(x => x.Office).WithOne(x =>x.Admin);
        }
    }
}
