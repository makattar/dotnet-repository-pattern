using App.Models.Dto.Response.Common;
using App.Models.Dto.Response.Organization;
using App.Models.Dto.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Interface.User
{
    public interface IUserService
    {
        Task<ResponseDto<PaginatedResponseDto<IEnumerable<UserDto>>>> GetAllUsers(int page, int size);
    }
}
