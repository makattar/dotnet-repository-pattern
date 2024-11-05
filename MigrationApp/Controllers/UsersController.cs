using App.Service.Interface.Organization;
using App.Service.Interface.User;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : BaseController
    {
        readonly IUserService _userService;
        public UsersController(IUserService userService) { this._userService = userService; }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers([FromQuery] int page, [FromQuery] int size)
        {
            return Ok(_userService.GetAllUsers(page,size));
        }
    }
}
