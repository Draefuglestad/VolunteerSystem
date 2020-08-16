using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteerSystem.Migrations
{
    public partial class Opportunities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "volunteerDate",
                table: "Opportunities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
