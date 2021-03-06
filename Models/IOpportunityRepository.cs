﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VolunteerSystem.Models
{
    public interface IOpportunityRepository
    {
         IEnumerable<Opportunity> Opportunities {get;}

        void SaveOpportunity(Opportunity opportunity);

        Opportunity DeleteOpportunity(int opportunityID);
    }
}
