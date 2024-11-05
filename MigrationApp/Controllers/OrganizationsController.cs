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
    }
}
