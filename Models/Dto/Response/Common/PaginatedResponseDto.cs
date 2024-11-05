using App.Models.Dto.Response.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Dto.Response.Common
{
    public class PaginatedResponseDto<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool isNextPresent { get; set; }
        public bool isPrevPresent { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public T Data { get; set; }
    }
}
