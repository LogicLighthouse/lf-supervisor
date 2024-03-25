using Microsoft.AspNetCore.Mvc;
using SMNS.Services;
using System.Threading.Tasks;

namespace SMNS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupervisorsController : ControllerBase
    {
        private readonly ISupervisorService _supervisorService;

        public SupervisorsController(ISupervisorService supervisorService)
        {
            _supervisorService = supervisorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var supervisors = await _supervisorService.GetSupervisorsAsync();
            return Ok(supervisors);
        }
    }
}
