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
        private IVolunteerRepository repository;

        public NavigationMenuViewComponent(IVolunteerRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["approvalStatus"];
            return View(repository.Volunteers
                .Select(x => x.ApprovalStatus)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}

