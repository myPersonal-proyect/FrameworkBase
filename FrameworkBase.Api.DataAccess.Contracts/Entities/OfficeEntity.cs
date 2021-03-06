﻿using System.Collections.Generic;

namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class OfficeEntity
    {
        public int OfficeId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public bool Active { get; set; }

        public bool HasIndividualWorkSpace { get; set; }

        public int NumerWorkSpace { get; set; }

        public decimal PriceWorkSpaceDaily { get; set; }

        public decimal PriceWorkSpaceMonthly { get; set; }
        
        public int AdminId { get; set; }
        public virtual AdminEntity Admin { get; set; }
         
        public virtual BookingEntity Booking { get; set; }

        public virtual ICollection<Office2RoomsEntity> Office2Rooms { get; set; }

    }
}
