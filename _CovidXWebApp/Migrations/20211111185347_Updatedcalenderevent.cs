using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class Updatedcalenderevent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
