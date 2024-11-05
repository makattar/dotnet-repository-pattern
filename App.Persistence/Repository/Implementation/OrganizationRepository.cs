using App.Persistence.Entity;
using App.Persistence.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Repository.Implementation
{
    public class OrganizationRepository : GenericRepository<Organization>,IOrganizationRepository
    {
        public OrganizationRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
