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

        public void SaveOpportunity(Opportunity opportunity)
        {
            if (opportunity.OpportunityID == 0)
            {
                context.Opportunities.Add(opportunity);
            }
            else
            {
                Opportunity dbEntry = context.Opportunities
                .FirstOrDefault(p => p.OpportunityID == opportunity.OpportunityID);
                if (dbEntry != null)
                {
                    dbEntry.JobTitle = opportunity.JobTitle;
                    dbEntry.Description = opportunity.Description;
                    dbEntry.VolunteerCenter = opportunity.VolunteerCenter;
                    
                }
            }
            context.SaveChanges();
        }

        public Opportunity DeleteOpportunity(int opportunityID)
        {
            Opportunity dbEntry = context.Opportunities
            .FirstOrDefault(p => p.OpportunityID == opportunityID);
            if (dbEntry != null)
            {
                context.Opportunities.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}