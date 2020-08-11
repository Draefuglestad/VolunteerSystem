using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace VolunteerSystem.Controllers
{
    public class AdminOpController : Controller
    {
        private IOpportunityRepository repository;
        public AdminOpController(IOpportunityRepository repo)
        {
            repository = repo;
        }
        public ViewResult IndexOp() => View(repository.Opportunities);
    }
}
