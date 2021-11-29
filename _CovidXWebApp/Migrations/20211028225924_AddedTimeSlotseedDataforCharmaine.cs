using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedTimeSlotseedDataforCharmaine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tests_TestRequestId",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestRequestId",
                table: "Tests",
                column: "TestRequestId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tests_TestRequestId",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestRequestId",
                table: "Tests",
                column: "TestRequestId");
        }
    }
}
