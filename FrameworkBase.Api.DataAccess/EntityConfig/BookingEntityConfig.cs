using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameworkBase.Api.DataAccess.EntityConfig
{
    public class BookingEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingEntity> entityBuilder)
        {
            entityBuilder.ToTable("Bookings");

            entityBuilder.HasKey(x => x.BookingId);
            entityBuilder.Property(x => x.BookingId).IsRequired();

            entityBuilder.HasOne(x => x.Office).WithOne(x => x.Booking);
            entityBuilder.HasOne(x => x.User).WithOne(x => x.Booking);
        }
    }
}
