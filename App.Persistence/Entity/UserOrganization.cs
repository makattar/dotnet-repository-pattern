namespace App.Persistence.Entity
{
    public class UserOrganization : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
