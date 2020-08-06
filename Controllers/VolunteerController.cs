using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
using VolunteerSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace VolunteerSystem.Controllers
{
    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        public int PageSize = 10;
        public VolunteerController(IVolunteerRepository repo) 
        { 
            repository = repo; 
        }
        public IActionResult Index()
        {
            return RedirectToAction("Admin/Index");
        }
        public ViewResult VolunteerList(int page = 1) 
            => View(new VolunteersListViewModels 
            { 
                Volunteers = repository.Volunteers
                .OrderBy(p => p.VolunteerID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                { 
                    CurrentPage = page, 
                    ItemsPerPage = PageSize, 
                    TotalItems = repository.Volunteers.Count() 
                }
            }
            );

    }
}
