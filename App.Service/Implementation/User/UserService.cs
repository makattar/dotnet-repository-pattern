using App.Models.Dto.Response.Common;
using App.Models.Dto.Response.Organization;
using App.Models.Dto.Response.User;
using App.Persistence.Repository.Implementation;
using App.Persistence.Repository.Interface;
using App.Service.Converters;
using App.Service.Interface.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Implementation.User
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResponseDto<PaginatedResponseDto<IEnumerable<UserDto>>>> GetAllUsers(int page, int size)
        {
            var users = await _userRepository.DbSet.Where(user => user.IsDeleted == false).Skip(page * size).Take(size).ToListAsync();
            var usersCount = await _userRepository.DbSet.Where(user => user.IsDeleted == false).CountAsync();
            var totalPages = (int)Math.Ceiling(usersCount / (double)size);
            return new ResponseDto<PaginatedResponseDto<IEnumerable<UserDto>>>
            {
                Succeeded = true,
                Errors = new List<string>(),
                Message = "",
                Data = new PaginatedResponseDto<IEnumerable<UserDto>>
                {
                    PageNumber = page,
                    PageSize = size,
                    TotalPages = totalPages,
                    TotalRecords = usersCount,
                    isNextPresent = totalPages - 1 > page,
                    isPrevPresent = page > 0,
                    Data = users.ConvertAll(UserConverter.entityToDto)
                }
            };
        }
    }
}
