using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using VolunteerSystem.Models.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace VolunteerSystem.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IVolunteerRepository repository;

        public AdminController(IVolunteerRepository repo)
        {
            repository = repo;
        }


        //this ViewResult method links the search bar to the data base so that it searches through the database
        public ViewResult Index(string searchString, string searchOpp, string approvalStatus, string secondApprovalStatus, int page = 1)
        {
            var Volunteers = from v in repository.Volunteers select v;
            if (!string.IsNullOrEmpty(searchString))
            {
                Volunteers = Volunteers.Where(Volunteers =>
                Volunteers.FirstName.ToLower().Contains(searchString.ToLower()) ||
                Volunteers.LastName.ToLower().Contains(searchString.ToLower()));
                return View(Volunteers.ToList());
            }
            else if (!string.IsNullOrEmpty(secondApprovalStatus))
            {
                Volunteers = repository.Volunteers.Where(
                    p => secondApprovalStatus == null || p.ApprovalStatus == "Approved" || p.ApprovalStatus == "Pending Approval" || p.ApprovalStatus == "approved" || p.ApprovalStatus == "pending approval" || p.ApprovalStatus == "approved")
                    .OrderBy(p => p.VolunteerID);
            }
            
            else
            {
                Volunteers = repository.Volunteers.Where(
                    p => approvalStatus == null || p.ApprovalStatus == approvalStatus)
                    .OrderBy(p => p.VolunteerID);
            }
            return View(Volunteers.ToList());
        }

        

        public ViewResult Edit(int volunteerID) => View(repository.Volunteers
                .FirstOrDefault(p => p.VolunteerID == volunteerID));

        public ViewResult OppMatch(int volunteerID) => View(repository.Volunteers
                 .FirstOrDefault(p => p.VolunteerID == volunteerID));

        

        [HttpPost]
        public IActionResult Edit(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVolunteer(volunteer);
                TempData["message"] = $"{volunteer.LastName}, {volunteer.FirstName} has been saved";
                return RedirectToAction("Index");
            }
            else
            {                 // there is something wrong with the data values                
                return View(volunteer);
            }
        }
        public ViewResult Create() => View("Edit", new Volunteer());


        public ViewResult ManagePage()
        {
            return View();
        }

        //the ViewResult method links the Opportunity Match View page to the Opportunity Match button
        //public ViewResult OppMatch()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Delete(int volunteerId)
        {
            Volunteer deletedVolunteer = repository.DeleteVolunteer(volunteerId);
            if (deletedVolunteer != null)
            {
                TempData["message"] = $"{deletedVolunteer.LastName} was deleted";
            }
            return RedirectToAction("Index");
        }
    }

}
