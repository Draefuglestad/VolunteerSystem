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
    public class OpportunityController : Controller
    {
        private IOpportunityRepository repository;
        public int PageSize = 10;
        public OpportunityController(IOpportunityRepository repo)
            {
                repository = repo;
            }
        public ViewResult OpportunityList(int page = 1)
            => View(new OpportunitiesListViewModels
            {
        Opportunities = repository.Opportunities
                .OrderBy(p => p.OpportunityID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Opportunities.Count()
                }
            });
        // public ViewResult OpportunityList() => View(repository.Opportunities);

    }
}
