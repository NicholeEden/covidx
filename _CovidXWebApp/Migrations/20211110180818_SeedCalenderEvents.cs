using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class SeedCalenderEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[,]
                {
                    { 1, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 2, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 3, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 4, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 5, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 6, false, "1 Harbor Cottages Humerail", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "1 Harbor Cottages" },
                    { 15, false, "45 Columbia Crescent Missionvale", new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "45 Columbia Crescent" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 15);
        }
    }
}
