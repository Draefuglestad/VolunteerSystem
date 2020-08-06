using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerSystem.Models 
{ public class EFVolunteerRepository : IVolunteerRepository 
    { 
        private ApplicationDbContext context;
        public EFVolunteerRepository(ApplicationDbContext ctx) 
        { 
            context = ctx;
        } 
        public IEnumerable<Volunteer> Volunteers => context.Volunteers;

        public void SaveVolunteer(Volunteer volunteer) 
        {
            if (volunteer.VolunteerID == 0) 
            { 
                context.Volunteers.Add(volunteer); 
            }
            else { 
                Volunteer dbEntry = 
                    context.Volunteers
                    .FirstOrDefault(p => p.VolunteerID == volunteer.VolunteerID); 
                if (dbEntry != null)
                { 
                    dbEntry.FirstName = volunteer.FirstName; 
                    dbEntry.LastName = volunteer.LastName;
                    dbEntry.Username = volunteer.Username; 
                    dbEntry.Password = volunteer.Password;
                    dbEntry.Email = volunteer.Email;
                    dbEntry.PhoneNumber = volunteer.PhoneNumber;
                    dbEntry.EmergencyContactEmail = volunteer.EmergencyContactEmail;
                    dbEntry.EmergencyContactFirstName = volunteer.EmergencyContactFirstName;
                    dbEntry.EmergencyContactLastName = volunteer.EmergencyContactLastName;
                    dbEntry.EmergencyContactPhoneNumber = volunteer.EmergencyContactPhoneNumber;
                    dbEntry.EmergencyStreetAddress = volunteer.EmergencyStreetAddress;
                    dbEntry.EmergencyZipCode = volunteer.EmergencyZipCode;
                    dbEntry.EmergencyState = volunteer.EmergencyState;
                    dbEntry.EmergencyCity = volunteer.EmergencyState;
                    dbEntry.VolunteerCenter = volunteer.VolunteerCenter;
                    dbEntry.Skills = volunteer.Skills;
                    dbEntry.Interests = volunteer.Interests;
                    dbEntry.ZipCode = volunteer.ZipCode;
                    dbEntry.StreetAddress = volunteer.StreetAddress;
                    dbEntry.City = volunteer.City;
                    dbEntry.State = volunteer.State;
                    dbEntry.Driverslicense = volunteer.Driverslicense;
                    dbEntry.SSN = volunteer.SSN;
                    dbEntry.AvailabilityTimes = volunteer.AvailabilityTimes;
                    dbEntry.Education = volunteer.Education;
                    dbEntry.Licenses = volunteer.Licenses;
                    dbEntry.ApprovalStatus = volunteer.ApprovalStatus;


                }
            } context.SaveChanges();
        }
    } 
}