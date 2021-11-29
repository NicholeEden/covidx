using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class AddedResultDateTestDateTesttimeToTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 1,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 2,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 10, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 3,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 10, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 4,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 11, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 5,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 11, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 6,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 12, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 7,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 8,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 10, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 9,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 8, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 11, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 10,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 11,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 13, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 12,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 13, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 13,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 13, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 14,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 3, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 14, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 15,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { new DateTime(2021, 3, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 14, 41, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 1,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 2,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 3,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 4,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 5,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 6,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 7,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 8,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 9,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 10,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 11,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 12,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 13,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 14,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 15,
                columns: new[] { "ResultDate", "TestDate", "TestTime" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
