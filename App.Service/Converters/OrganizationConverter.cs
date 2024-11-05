using App.Models.Dto.Response.Organization;
using App.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Converters
{
    public static class OrganizationConverter
    {
        public static OrganizationDto entityToDto(Organization entity)
        {
            return new OrganizationDto()
            {
                Id = entity.Id,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedBy = entity.CreatedBy,
                UpdatedBy = entity.UpdatedBy,
                IsDeleted = entity.IsDeleted,
                Name = entity.Name
            };
        }
    }
}
