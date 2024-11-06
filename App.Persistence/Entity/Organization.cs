using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Entity
{
    [Index(nameof(Name), IsUnique = true)]
    public class Organization : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<UserOrganization> UserOrganizations { get; set; }
    }
}
