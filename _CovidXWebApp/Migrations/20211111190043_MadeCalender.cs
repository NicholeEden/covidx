using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class MadeCalender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[] { 15, false, "45 Columbia Crescent Missionvale", new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "45 Columbia Crescent" });
        }
    }
}
