using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
using System.Linq;

namespace VolunteerSystem.Controllers
{
    public class AdminController : Controller
    {
        private IVolunteerRepository repository;

        public AdminController(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Volunteers);

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
           
    }
}
