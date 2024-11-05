using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Entity
{
    public class User : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        public List<UserOrganization> UserOrganizations { get; set; }
        
    }
}
