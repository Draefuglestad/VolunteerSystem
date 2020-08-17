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
        [Required(ErrorMessage = "Please enter a Volunteer Center")]
        public string VolunteerCenter { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a job title")]
        public string JobTitle { get; set; }
       [Required(ErrorMessage ="Please enter a keyword for this job")]
        public string Keyword { get; set; }

       // public DateTime OppDate { get; set; }
    }
}
