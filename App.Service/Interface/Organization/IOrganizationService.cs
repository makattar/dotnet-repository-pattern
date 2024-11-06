using App.Models.Dto.Request.Organization;
using App.Models.Dto.Response.Common;
using App.Models.Dto.Response.Organization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Interface.Organization
{
    public interface IOrganizationService
    {
        Task<ResponseDto<PaginatedResponseDto<IEnumerable<OrganizationDto>>>> GetAllOrganizations(int page,int size);
        Task<ResponseDto<OrganizationDto>> CreateOrganization(CreateOrganization createOrganization);
        Task<ResponseDto<OrganizationDto>> GetOrganization(int id);
    }
}
