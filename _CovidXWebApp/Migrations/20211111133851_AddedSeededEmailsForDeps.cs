using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedSeededEmailsForDeps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 91,
                column: "EmailAddress",
                value: "daleen@gmail.com");

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 92,
                column: "EmailAddress",
                value: "charmaine@gmail.com");

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 93,
                column: "EmailAddress",
                value: "charmaine@gmail.com");

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 94,
                column: "EmailAddress",
                value: "charmaine@gmail.com");

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 95,
                column: "EmailAddress",
                value: "lesedi@gmail.com");

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 96,
                column: "EmailAddress",
                value: "jacob@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 91,
                column: "EmailAddress",
                value: null);

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 92,
                column: "EmailAddress",
                value: null);

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 93,
                column: "EmailAddress",
                value: null);

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 94,
                column: "EmailAddress",
                value: null);

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 95,
                column: "EmailAddress",
                value: null);

            migrationBuilder.UpdateData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 96,
                column: "EmailAddress",
                value: null);
        }
    }
}
