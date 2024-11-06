using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Dto.Request.Organization
{
    public class CreateOrganization
    {
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
    }
}
