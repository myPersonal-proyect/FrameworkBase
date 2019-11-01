using System.Threading.Tasks;

namespace FrameworkBase.Api.Application.Contracts.Services
{
    public interface IUserService
    {
        Task GetUserName(int idUser, int idAdmin);
    }
}
