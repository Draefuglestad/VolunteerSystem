using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

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
        //public ViewResult Index() => View(repository.Volunteers);
        
        //this ViewResult method links the search bar to the data base so that it searches through the database
        public ViewResult Index(string searchString)
        {
            //ViewBag.NameSortParm = String.IsNullOrEmpty()
            var Volunteers = from v in repository.Volunteers select v;
            if (!string.IsNullOrEmpty(searchString))
            {
                Volunteers = Volunteers.Where(Volunteers => Volunteers.FirstName.Contains(searchString) || Volunteers.LastName.Contains(searchString));
            }
            return View(Volunteers.ToList());
        }

        public ViewResult Edit(int volunteerID) => View(repository.Volunteers
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
