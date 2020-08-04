using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerSystem.Models
{
    public class FakeVolunteerRepository : IVolunteerRepository
    {
        public IEnumerable<Volunteer> Volunteers => new List<Volunteer>
        {
            new Volunteer { FirstName = "Rachael", LastName = "Cook" },
            new Volunteer { FirstName = "Danielle", LastName = "Rae" },
            new Volunteer { FirstName = "Bailey", LastName = "McIntrye" },
            new Volunteer { FirstName = "Katrina", LastName = "Diduryk" },
        };
    }
}
