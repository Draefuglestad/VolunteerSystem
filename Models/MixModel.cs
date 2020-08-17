using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using VolunteerSystem.Models;
using VolunteerSystem.Models.ViewModels;

namespace VolunteerSystem.Models
{
    public class MixModel
    {
        public Volunteer Volunteer { get; set; }
        public Opportunity Opportunity{ get; set; }
    }
}
