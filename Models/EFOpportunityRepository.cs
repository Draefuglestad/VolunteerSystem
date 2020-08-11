using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerSystem.Models
{
    public class EFOpportunityRepository : IOpportunityRepository
    {
        private ApplicationDbContext context;
        public EFOpportunityRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Opportunity> Opportunities => context.Opportunities;
    }
}