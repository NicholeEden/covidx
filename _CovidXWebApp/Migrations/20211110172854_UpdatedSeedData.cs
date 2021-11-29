using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Temperature",
                table: "Tests",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OxygenLevel",
                table: "Tests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                column: "CalenderEventID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                column: "CalenderEventID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                column: "CalenderEventID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                column: "CalenderEventID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                column: "CalenderEventID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 6,
                columns: new[] { "CalenderEventID", "DateAssigned", "EndTime", "StartTime" },
                values: new object[] { 6, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 14, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "CalenderEventID", "DateAssigned", "EndTime", "NurseId", "RequestDate", "RequestStatus", "StartTime" },
                values: new object[] { 15, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Temperature",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "OxygenLevel",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1,
                column: "CalenderEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2,
                column: "CalenderEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3,
                column: "CalenderEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4,
                column: "CalenderEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5,
                column: "CalenderEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 6,
                columns: new[] { "CalenderEventID", "DateAssigned", "EndTime", "StartTime" },
                values: new object[] { null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 7,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 8,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 9,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 10,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 11,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 12,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 13,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 14,
                column: "RequestDate",
                value: new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15,
                columns: new[] { "CalenderEventID", "DateAssigned", "EndTime", "NurseId", "RequestDate", "RequestStatus", "StartTime" },
                values: new object[] { null, null, null, null, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestId", "BarCode", "BloodPressure", "LabUserId", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestId", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 15, "COV-ABC-1030-09", "124/79", 1, "94", null, "38,5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "COV-ABC-1030-08", "124/79", 1, "92", null, "38,2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "COV-ABC-1030-07", "120/80", 1, "99", null, "34,2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "COV-ABC-1020-06", "124/79", 1, "91", null, "37,2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "COV-ABC-1020-05", "120/80", 1, "100", null, "34,5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "COV-ABC-1020-04", "124/79", 1, "93", null, "38,1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "COV-ABC-1020-03", "120/80", 1, "91", null, "37,4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "COV-ABC-1020-02", "124/79", 1, "92", null, "36,9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "COV-ABC-1020-01", "120/80", 1, "100", null, "35,1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "COV-ABC-1010-05", "124/79", 1, "90", null, "37,9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "COV-ABC-1010-04", "120/80", 1, "99", null, "35,8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "COV-ABC-1010-03", "124/79", 1, "99", null, "34,6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Negative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "COV-ABC-1010-02", "120/80", 1, "97", null, "38,2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "COV-ABC-1030-09", "120/80", 1, "93", null, "37,9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "COV-ABC-1010-01", "124/79", 1, "95", null, "37,5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Positive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
