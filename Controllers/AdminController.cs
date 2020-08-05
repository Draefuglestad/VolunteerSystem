using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
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
    }
}
