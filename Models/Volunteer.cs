using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;



namespace VolunteerSystem.Models
{


    public class Volunteer
    {
        public int VolunteerID { get; set; }
        [Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a valid username name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a valid password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter a valid emergency contact email")]
        public string EmergencyContactEmail { get; set; }
        [Required(ErrorMessage = "Please enter an emergency contact first name")]
        public string EmergencyContactFirstName { get; set; }

        [Required(ErrorMessage = "Please enter an emergency contact last name")]
        public string EmergencyContactLastName { get; set; }

        [Required(ErrorMessage = "Please enter an emergency contact phone number")]

        public string EmergencyContactPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an emergency contact zip code")]
        public string EmergencyZipCode { get; set; }
        [Required(ErrorMessage = "Please enter an emergency contact street address")]
        public string EmergencyStreetAddress { get; set; }
        [Required(ErrorMessage = "Please enter an emergency contact city")]
        public string EmergencyCity { get; set; }
        [Required(ErrorMessage = "Please enter an emergency contact state")]
        public string EmergencyState { get; set; }
        [Required(ErrorMessage = "Please enter a volunteer center")]
        public string VolunteerCenter { get; set; }

        [Required(ErrorMessage = "Please enter volunteer's skills")]
        public string Skills { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's interests")]
        public string Interests { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's zip code")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's street address")]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please check if drivers license is on file")]
        public bool Driverslicense { get; set; }
        [Required(ErrorMessage = "Please check if social security number is on file")]
        public bool SSN { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's starting availability time")]
        public string AvailabilityTimes { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's education")]
        public string Education { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's qualifying license(s)")]
        public string Licenses { get; set; }
        [Required(ErrorMessage = "Please enter volunteer's approval status")]
        public string ApprovalStatus { get; set; }
    }

 }
