using FrameworkBase.Api.Business.Models;
using FrameworkBase.Api.DataAccess.Contracts.Entities;

namespace FrameworkBase.Api.DataAccess.Mappers
{
    public static class AdminMappers
    {
        public static AdminEntity Map(Admin dto)
        {
            return new AdminEntity
            {
                Name = dto.Name,
                Email = dto.Email,
                Address = dto.Address,
                Phone = dto.Phone,

            };
        }

        public static Admin Map(AdminEntity entity)
        {
            return new Admin
            {

                Name = entity.Name,
                Email = entity.Email,
                Address = entity.Address,
                Phone = entity.Phone,

            };
        }
    }
}
