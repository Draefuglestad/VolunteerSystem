using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerSystem.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactFirstName { get; set; }
        public string EmergencyContactLastName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string EmergencyZipCode { get; set; }
        public string EmergencyStreetAddress { get; set; }
        public string EmergencyCity { get; set; }
        public string EmergencyState { get; set; }
        public string VolunteerCenter { get; set; }
        public string Skills { get; set; }
        public string Interests { get; set; }
        public string ZipCode { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Driverslicense { get; set; }
        public bool SSN { get; set; }
        public string AvailabilityTimes { get; set; }
        public string Education { get; set; }
        public string Licenses { get; set; }
        public string ApprovalStatus { get; set; }



    }
}
