using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerSystem.Models 
{ public class EFVolunteerRepository : IVolunteerRepository 
    { 
        private ApplicationDbContext context;
        public EFVolunteerRepository(ApplicationDbContext ctx) 
        { 
            context = ctx;
        } 
        public IEnumerable<Volunteer> Volunteers => context.Volunteers; 
    } 
}