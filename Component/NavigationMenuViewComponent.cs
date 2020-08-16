using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;

namespace VolunteerSystem.Component
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IOpportunityRepository repository;

        public NavigationMenuViewComponent(IOpportunityRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["centerFilter"];
            return View(repository.Opportunities
                .Select(x => x.VolunteerCenter)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}

