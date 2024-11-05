using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Entity
{
    public class Organization : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<UserOrganization> UserOrganizations { get; set; }
    }
}
