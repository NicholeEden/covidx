using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class SeedTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestId", "BarCode", "BloodPressure", "LabUserId", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestId", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 1, "COV-ABC-1010-01", "124/79", 1, 95, null, 37.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "COV-ABC-1010-02", "120/80", 1, 97, null, 38.200000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "COV-ABC-1010-03", "124/79", 1, 99, null, 34.600000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "COV-ABC-1010-04", "120/80", 1, 99, null, 35.799999999999997, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "COV-ABC-1010-05", "124/79", 1, 90, null, 37.899999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "COV-ABC-1020-01", "120/80", 1, 100, null, 35.100000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "COV-ABC-1020-02", "124/79", 1, 92, null, 36.899999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "COV-ABC-1020-03", "120/80", 1, 91, null, 37.399999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "COV-ABC-1020-04", "124/79", 1, 93, null, 38.100000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "COV-ABC-1020-05", "120/80", 1, 100, null, 34.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "COV-ABC-1020-06", "124/79", 1, 91, null, 37.200000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "COV-ABC-1030-07", "120/80", 1, 99, null, 34.200000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "COV-ABC-1030-08", "124/79", 1, 92, null, 38.200000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "COV-ABC-1030-09", "120/80", 1, 93, null, 37.899999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "COV-ABC-1030-09", "124/79", 1, 94, null, 38.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestId",
                keyValue: 15);
        }
    }
}
