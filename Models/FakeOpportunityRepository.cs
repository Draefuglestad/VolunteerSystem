using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerSystem.Models
{
    public class FakeOpportunityRepository : IOpportunityRepository
    {
        public IEnumerable<Opportunity> Opportunities => new List<Opportunity> {
            new Opportunity {JobTitle= "Groomer", Description="Grooming Homeless Pets" },
            new Opportunity {JobTitle= "Groomer", Description="Grooming Homeless Pets" },
        };
    }
}