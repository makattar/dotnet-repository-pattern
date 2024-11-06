using App.Models.Dto.Request.Organization;
using App.Models.Dto.Response.Organization;
using App.Service.Interface.Organization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganizationsController : BaseController
    {
        readonly IOrganizationService _organizationService;
        public OrganizationsController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrganizations([FromQuery] int page, [FromQuery] int size)
        {
            return Ok(await _organizationService.GetAllOrganizations(page, size));
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrganization([FromBody] CreateOrganization createOrganization)
        {
            return Ok(await _organizationService.CreateOrganization(createOrganization));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrganization([FromRoute]int id)
        {
            var result = await _organizationService.GetOrganization(id);
            return result.Succeeded ? Ok(result) : NotFound();
        }
    }
}
