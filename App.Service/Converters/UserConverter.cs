using App.Models.Dto.Response.Organization;
using App.Models.Dto.Response.User;
using App.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Converters
{
    public class UserConverter
    {
        public static UserDto entityToDto(User entity)
        {
            return new UserDto()
            {
                Id = entity.Id,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedBy = entity.CreatedBy,
                UpdatedBy = entity.UpdatedBy,
                IsDeleted = entity.IsDeleted,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
    }
}
