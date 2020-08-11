using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace VolunteerSystem.Models
{
    public class Opportunity
    {
        public int OpportunityID { get; set; }
        public string VolunteerCenter { get; set; } 
        public string Description { get; set; }
        public string JobTitle { get; set; }
    }
}
