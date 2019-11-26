using System;

namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class BookingEntity
    {
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CreateBooking { get; set; }

        public bool RentWorkSpace { get; set; }

      
        public int UserId { get; set; }

        public int OfficeId { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual OfficeEntity Office { get; set; }


    }
}
