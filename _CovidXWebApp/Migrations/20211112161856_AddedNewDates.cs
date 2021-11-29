using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedNewDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                columns: new[] { "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 6,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 7,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 8,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 9,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 10,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 11,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 12,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 13,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 14,
                column: "RequestDate",
                value: new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                columns: new[] { "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 6,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 7,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 8,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 9,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 10,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 11,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 12,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 13,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 14,
                column: "RequestDate",
                value: new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                columns: new[] { "DateAssigned", "EndTime", "RequestDate", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
