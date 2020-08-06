using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerSystem.Models
{
    public interface IVolunteerRepository 
    {
        IEnumerable<Volunteer> Volunteers
        {get;}

        void SaveVolunteer(Volunteer volunteer);
    }
}
