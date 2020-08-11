using System.Linq;
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
        public ViewResult Index() => View(repository.Opportunities);

        public ViewResult Edit(int opportunityID) =>
                    View(repository.Opportunities
                    .FirstOrDefault(p => p.OpportunityID == opportunityID));

        [HttpPost]
        public IActionResult Edit(Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOpportunity(opportunity);
                TempData["message"] = $"{opportunity.VolunteerCenter} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(opportunity);
            }
        }
    }
}
