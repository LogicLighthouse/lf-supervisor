using Microsoft.AspNetCore.Mvc;
using SMNS.Models;
using SMNS.Services;
using System.Threading.Tasks;

namespace SMNS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> Submit([FromBody] NotificationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _notificationService.ProcessNotificationRequestAsync(request);
            return Ok("Notification request processed successfully.");
        }
    }
}
