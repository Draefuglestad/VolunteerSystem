﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerSystem.Models;

namespace VolunteerSystem.Models.ViewModels
{
    public class VolunteersListViewModels
    {
        public IEnumerable<Volunteer> Volunteers { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
