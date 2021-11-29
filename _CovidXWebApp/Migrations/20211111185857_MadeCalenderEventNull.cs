using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class MadeCalenderEventNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                column: "CalenderEventID",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                column: "CalenderEventID",
                value: 15);
        }
    }
}
