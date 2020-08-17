using System.Linq;
using VolunteerSystem.Models;
using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models.ViewModels;
using System;

namespace VolunteerSystem.Controllers
{
    public class AdminOpController : Controller
    {
        private IOpportunityRepository repository;
        public AdminOpController(IOpportunityRepository repo)
        {
            repository = repo;
        }
       

        public ViewResult Edit(int opportunityID) =>
                    View(repository.Opportunities
                    .FirstOrDefault(p => p.OpportunityID == opportunityID));

        
        public ViewResult Index(string searchOpp, string centerFilter, string dateFilter)
        {
            var Opportunities = from o in repository.Opportunities select o;
            if (!string.IsNullOrEmpty(searchOpp))
            {
                //method that searches opportunities (search bar function Views/AdminOpp/Index)
                Opportunities = Opportunities.Where(o => o.Keyword.Contains(searchOpp));
            } else if (!string.IsNullOrEmpty(centerFilter))
            {
                Opportunities = repository.Opportunities.Where(
                    Opportunities => Opportunities.VolunteerCenter == null || Opportunities.VolunteerCenter == centerFilter);
            } else if (!string.IsNullOrEmpty(dateFilter))
            {
                //DateTime currentDate = DateTime.Now.Date.AddDays(-60);
                //Opportunities = repository.Opportunities.Where(p => p.volunteerDate >= currentDate
                //|| p.volunteerDate == currentDate);
            }
            return View(Opportunities.ToList());
        }

        [HttpPost]
        public IActionResult Edit(Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOpportunity(opportunity);
                TempData["message"] = $"{opportunity.JobTitle} at {opportunity.VolunteerCenter} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(opportunity);
            }
        }

        public ViewResult Create() => View("Edit", new Opportunity());

        [HttpPost]
        public IActionResult Delete(int opportunityId)
        {
            Opportunity deletedOpportunity = repository.DeleteOpportunity(opportunityId);
            if (deletedOpportunity != null)
            {
                TempData["message"] = $"{deletedOpportunity.JobTitle} at {deletedOpportunity.VolunteerCenter} has been deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
