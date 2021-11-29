using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedLindiletoTestRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                column: "NurseId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                column: "NurseId",
                value: 1);
        }
    }
}
