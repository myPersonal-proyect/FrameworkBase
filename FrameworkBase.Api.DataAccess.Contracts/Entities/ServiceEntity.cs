using System.Collections.Generic;

namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class ServiceEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Room2ServiceEntity> Room2ServiceEntity { get; set; }

    }
}
