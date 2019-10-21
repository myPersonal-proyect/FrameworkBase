using System.Collections.Generic;

namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public virtual ICollection<Office2RoomsEntity> Office2Rooms { get; set; }

        public virtual ICollection<Room2ServiceEntity> Room2ServiceEntity { get; set; }


    }
}
