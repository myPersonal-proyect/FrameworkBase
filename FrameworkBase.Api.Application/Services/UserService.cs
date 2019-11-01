using FrameworkBase.Api.Application.Contracts.Services;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using System.Threading.Tasks;

namespace FrameworkBase.Api.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IAdminService _adminService;
        private readonly IUserRepository _userRepository;

        public UserService(IAdminService adminService,
                           IUserRepository userRepository)
        {
            _adminService = adminService;
            _userRepository = userRepository;
        }

        public async Task GetUserName(int idUser, int idAdmin)
        {
            await _userRepository.Get(idUser);
            await _adminService.GetAdminName(idAdmin);
        }
    }
}
