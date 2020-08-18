# VolunteerSystem
Summer Senior Project - Volunteer Web System Application

This is a pre-semester project for the Senior Project 1 course. The purpose of this web app is for the admin to 
be able to add, edit, or delete volunteers or volunteer opportunities. No one other than a person with an admin 
login has access to the information or to make changes.

For this project we did not have access to a shared database. Therefore, we each had to migrate and update
our local databases in SQL Server Object Explorer.

Features that are not working quite right:

- Filter by DateTime. 
   We struggled using the datatype date/datetime for the first time. I (Bailey) implemented the filter by date
   and was eventually able to get it to work. However, for some reason the database would not update on other
   team members system. Every person had to add the new datatype themselves otherwise the program would break
   whenever they tried to run it and select the Manage Opportunities button. 

- Opportunity Matching.
  The idea was to compare one volunteer's interest to the "keyword" column in the Opportunities database. I (Katrina) 
  ran into a problem in the view page, labeled "OppMatch". This view page lists the one volunteer's information and 
  lists the job opportunities that matched with the volunteer's interests. The issue I had was I'm not able to reference
  two Models in one view page, so to go around this, I did some googling and found out that I can create one Model that 
  holds both the Opportunity Model and the Volunteer Model. The Model that holds both is labeled "MixModel". I was unable
  to successfully complete this, but the "Opportunity Match" button works and prints out the volunteer information.

Things our team learned and would do differently next time:

- Push to branches, not master.
- Map out how we want to in take data to limit user error. For example, radio buttons, check boxes,and drop downs 
  instead of text boxes.
- Adding more comments to the code. 
- Following/keeping up with the Trello board in order to keep track of each other's progress and keep up with tasks.

