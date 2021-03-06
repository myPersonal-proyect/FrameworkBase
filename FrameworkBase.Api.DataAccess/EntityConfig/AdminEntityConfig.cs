﻿using FrameworkBase.Api.DataAccess.Contracts.Entities;
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

            entityBuilder.HasKey(x => x.OfficeId);
            entityBuilder.Property(x => x.OfficeId).IsRequired();


            // ---------- Relation ------------//

            entityBuilder.HasOne(x => x.Office).WithOne(x => x.Admin);
        }
    }
}
