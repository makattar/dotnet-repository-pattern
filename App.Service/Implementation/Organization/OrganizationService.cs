using App.Models.Dto.Response.Common;
using App.Models.Dto.Response.Organization;
using App.Persistence.Entity;
using App.Persistence.Repository.Interface;
using App.Service.Converters;
using App.Service.Interface.Organization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Implementation.Organization
{
    public class OrganizationService : IOrganizationService
    {
        readonly IOrganizationRepository _organizationRepository;
        public OrganizationService(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<ResponseDto<PaginatedResponseDto<IEnumerable<OrganizationDto>>>> GetAllOrganizations(int page, int size)
        {
            var organuizations = await _organizationRepository.DbSet.Where(org => org.IsDeleted == false).Skip(page * size).Take(size).ToListAsync();
            var organizationsCount = await _organizationRepository.DbSet.Where(org => org.IsDeleted == false).CountAsync();
            var totalPages = (int)Math.Ceiling(organizationsCount / (double)size);
            return new ResponseDto<PaginatedResponseDto<IEnumerable<OrganizationDto>>>
            {
                Succeeded = true,
                Errors = new List<string>(),
                Message = "",
                Data = new PaginatedResponseDto<IEnumerable<OrganizationDto>>
                {
                    PageNumber = page,
                    PageSize = size,
                    TotalPages = totalPages,
                    TotalRecords = organizationsCount,
                    isNextPresent = totalPages - 1 > page,
                    isPrevPresent = page > 0,
                    Data = organuizations.ConvertAll(OrganizationConverter.entityToDto)
                }
            };
        }
    }
}
