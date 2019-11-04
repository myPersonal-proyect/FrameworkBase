using FrameworkBase.Api.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Framework.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var name = await _adminService.GetAdminName(id);
            return Ok(name);
        }




    }
}