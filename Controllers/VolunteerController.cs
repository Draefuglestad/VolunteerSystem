using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerSystem.Models;
using VolunteerSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Dynamic;

namespace VolunteerSystem.Controllers
{
    //dynamic model to use two models in one view (OppMatch View uses Volunteer & Opportunity Controller)
    //public class AdminOpController: Controller
    //{
    //    public ActionResult Index()
    //    {
    //        dynamic mymodel = new ExpandoObject();
    //        mymodel.Volunteers = from v in repository.Volunteers select v;
    //        mymodel.Opportunities = from o in repository.Opportunities select o;
    //        return View(mymodel);
    //    }
    //}

    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        public int PageSize = 10;
        public VolunteerController(IVolunteerRepository repo) 
        { 
            repository = repo; 
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
