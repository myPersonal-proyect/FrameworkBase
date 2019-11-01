namespace FrameworkBase.Api.DataAccess.Contracts.Entities
{
    public class AdminEntity
    {
        public int AdminId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int OfficeId { get; set; }

        public virtual OfficeEntity Office { get; set; }

    }
}
