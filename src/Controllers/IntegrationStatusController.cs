using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IntegrationManager.Managers;
using IntegrationManager.Models;

namespace IntegrationManager.Controllers
{
    [ApiController]
    public class IntegrationStatusController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IRecurringIntegrationManager _recurringIntegrationManager;

        public IntegrationStatusController(ILogger<IntegrationStatusController> logger, IRecurringIntegrationManager recurringIntegrationManager)
        {
            _recurringIntegrationManager = recurringIntegrationManager;
            _logger = logger;
        }

        [HttpGet("api/Status")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ProducesResponseType(404)]
        [ProducesResponseType(typeof(string),500)]
        [ProducesResponseType(typeof(Status),200)]
        public async Task<IActionResult> GetStatus()
        {
            return Ok(_recurringIntegrationManager.GetStatus());
        }
    }
}