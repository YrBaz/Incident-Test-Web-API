using IncidentTestTask.Application;
using IncidentTestTask.Contracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace IncidentTestTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IIncidentService _incidentService;

        public IncidentController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpPost("newAccount")]
        public async Task<IActionResult> CreateAccount([FromBody] NewAccountDto model)
        {
            var result = await _incidentService.CreateAccount(model);

            return Ok(result);
        }

        [HttpPost("newIncident")]
        public async Task<IActionResult> CreateIncident([FromBody] NewIncidentDto model)
        {
            var result = await _incidentService.CreateIncident(model);

            return Ok(result);
        }
    }
}