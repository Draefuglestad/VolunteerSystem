using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteerSystem.Migrations
{
    public partial class OppDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VolunteerDate",
                table: "Opportunities");

            migrationBuilder.AddColumn<DateTime>(
                name: "OppDate",
                table: "Opportunities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OppDate",
                table: "Opportunities");

            migrationBuilder.AddColumn<DateTime>(
                name: "VolunteerDate",
                table: "Opportunities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
