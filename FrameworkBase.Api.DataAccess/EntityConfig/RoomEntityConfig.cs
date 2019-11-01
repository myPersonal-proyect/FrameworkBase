using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class RoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<RoomEntity> entityBuilder)
        {
            // ----------Table Admins ----------//
            entityBuilder.ToTable("Room");

            //---------- Id requered -----------//
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();


        }
    }
}
