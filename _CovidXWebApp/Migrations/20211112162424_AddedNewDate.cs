using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedNewDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                column: "DateAssigned",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                column: "DateAssigned",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
