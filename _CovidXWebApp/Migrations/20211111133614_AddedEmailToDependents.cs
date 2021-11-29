using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedEmailToDependents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Dependent",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Dependent");
        }
    }
}
