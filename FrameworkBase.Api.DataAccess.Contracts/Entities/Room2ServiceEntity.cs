namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class Room2ServiceEntity
    {
        public int RoomId { get; set; }

        public int ServiceId { get; set; }

        public virtual RoomEntity Room { get; set; }

        public virtual ServiceEntity Service { get; set; }
    }
}
