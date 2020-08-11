using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerSystem.Models;

namespace VolunteerSystem.Models.ViewModels
{
    public class OpportunitiesListViewModels
    {
        public IEnumerable<Opportunity> Opportunities { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
