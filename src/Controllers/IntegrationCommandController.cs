using System.Threading.Tasks;
using IntegrationManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IntegrationManager.Controllers
{
    [ApiController]
    [Authorize]
    public class IntegrationCommandController : ControllerBase
    {
        private readonly ILogger _logger;
        // TODO: add dependency for integration API

        public IntegrationCommandController(ILogger<IntegrationCommandController> logger)
        {
            _logger = logger;
        }

        [HttpPost("api/Commands/{command}")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ProducesResponseType(typeof(string), 500)]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<ActionResult> PostCommand([FromRoute] Command command, [FromBody] string payload)
        {
            // Call integration API and return response
            return Ok();
        }
    }
}