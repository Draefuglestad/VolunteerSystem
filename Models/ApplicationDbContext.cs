﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VolunteerSystem.Models
{ public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid> 
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
    }
}