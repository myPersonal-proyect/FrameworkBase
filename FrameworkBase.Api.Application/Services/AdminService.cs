using FrameworkBase.Api.Application.Contracts.Services;
using FrameworkBase.Api.Business.Models;
using FrameworkBase.Api.DataAccess.Mappers;
using FrameworkBase.Api.DataAccess.Repositories;
using System.Threading.Tasks;

namespace FrameworkBase.Api.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        public async Task<string> GetAdminName(int id)
        {
            var entidad = await _adminRepository.Get(id);

            return entidad.Name;
        }


        public async Task<Admin> AddAdmin(Admin admin)
        {
            var addedEntity = await _adminRepository.Add(AdminMappers.Map(admin));

            return AdminMappers.Map(addedEntity);
        }



    }
}
