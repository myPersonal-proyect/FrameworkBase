using System.Threading.Tasks;

namespace FrameworkBase.Api.Application.Contracts.Services
{
    public interface IAdminService
    {
        Task<string> GetAdminName(int idAdmin);
    }
}
