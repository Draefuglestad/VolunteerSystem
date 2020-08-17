using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteerSystem.Migrations
{
    public partial class OpTestBay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "volunteerDate",
                table: "Opportunities",
                newName: "VolunteerDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VolunteerDate",
                table: "Opportunities",
                newName: "volunteerDate");
        }
    }
}
