using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteerSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmergencyContactEmail = table.Column<string>(nullable: true),
                    EmergencyContactFirstName = table.Column<string>(nullable: true),
                    EmergencyContactLastName = table.Column<string>(nullable: true),
                    EmergencyContactPhoneNumber = table.Column<string>(nullable: true),
                    EmergencyZipCode = table.Column<string>(nullable: true),
                    EmergencyStreetAddress = table.Column<string>(nullable: true),
                    EmergencyCity = table.Column<string>(nullable: true),
                    EmergencyState = table.Column<string>(nullable: true),
                    VolunteerCenter = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Interests = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Driverslicense = table.Column<bool>(nullable: false),
                    SSN = table.Column<bool>(nullable: false),
                    AvailabilityTimes = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Licenses = table.Column<string>(nullable: true),
                    ApprovalStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.VolunteerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
