using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dependent",
                columns: new[] { "DependentId", "AddressLine1", "AddressLine2", "DependencyCode", "DependentTypeId", "Dob", "EmailAddress", "FirstName", "Gender", "Idnumber", "LastName", "MainMemberId", "MedicalAidNo", "MedicalAidPlanId", "MedicalAidStatus", "MobileNumber", "PersonResponsible", "SuburbId" },
                values: new object[,]
                {
                    { 91, "19 Admirality Way", null, null, 1006, new DateTime(1958, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daleen@gmail.com", "Dalene", 0, "5803180224083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 92, "19 Admirality Way", null, null, 1007, new DateTime(2012, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "charmaine@gmail.com", "Vince", 1, "1205050225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 93, "19 Admirality Way", null, null, 1007, new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "charmaine@gmail.com", "Vanessa", 0, "1607070225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 94, "19 Admirality Way", null, null, 1006, new DateTime(1953, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "charmaine@gmail.com", "Daniel", 1, "5309130225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 95, "24 7th Avenue", null, null, 1002, new DateTime(1983, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "lesedi@gmail.com", "Lesedi", 0, "8307070225083", "Moloi", 2, null, null, false, "0772458796", "Jacob Moloi", 127 },
                    { 96, "24 7th Avenue", null, null, 1007, new DateTime(2011, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jacob@gmail.com", "Thabo", 1, "1107090225083", "Moloi", 2, null, null, false, "0822458796", "Jacob Moloi", 127 }
                });

            migrationBuilder.InsertData(
                table: "TestRequests",
                columns: new[] { "TestRequestId", "CalenderEventID", "DateAssigned", "DependentId", "EndTime", "NurseId", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbId", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 28, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 84, "29 Peace Street", null },
                    { 27, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 84, "13 Congo Avenue", null },
                    { 26, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, "12 Marshall Road", null },
                    { 25, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, "37 The Beaches", "Beach Road" },
                    { 24, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 127, "28 7th Avenue", null },
                    { 23, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "6 Rubin Crescent", null },
                    { 22, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 57, "27 Aspen Complex", "La Roche Drive" },
                    { 21, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 16, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 15, 15, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 84, "45 Columbia Crescent", null },
                    { 12, null, null, null, null, null, 9, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "13 Congo Avenue", null },
                    { 13, null, null, null, null, null, 10, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "29 Peace Street", null },
                    { 29, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 11, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 84, "7 Jacks Road", null },
                    { 11, null, null, null, null, null, 8, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "12 Marshall Road", null },
                    { 10, null, null, null, null, null, 7, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 56, "37 The Beaches", "Beach Road" },
                    { 9, null, null, null, null, null, 6, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 127, "28 7th Avenue", null },
                    { 8, null, null, null, null, null, 5, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 126, "6 Rubin Crescent", null },
                    { 7, null, null, null, null, null, 4, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "27 Aspen Complex", "La Roche Drive" },
                    { 6, 6, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 1, 1, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 14, null, null, null, null, null, 11, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "7 Jacks Road", null },
                    { 30, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 84, "45 Columbia Crescent", null }
                });

            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[,]
                {
                    { 15, false, "45 Columbia Crescent Missionvale", new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "45 Columbia Crescent" },
                    { 6, false, "1 Harbor Cottages Humerail", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "1 Harbor Cottages" },
                    { 1, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" }
                });

            migrationBuilder.InsertData(
                table: "TestRequests",
                columns: new[] { "TestRequestId", "CalenderEventID", "DateAssigned", "DependentId", "EndTime", "NurseId", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbId", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 20, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 5, 5, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 2, 2, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 4, 4, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 18, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 3, 3, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 17, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 19, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestId", "BarCode", "BloodPressure", "LabUserId", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestId", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 14, "COV-ABC-1030-09", "120/80", 1, 93, new DateTime(2021, 3, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 37.899999999999999, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Positive", new DateTime(2021, 2, 28, 14, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "COV-ABC-1010-01", "124/79", 1, 95, new DateTime(2021, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 37.5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Positive", new DateTime(2021, 2, 1, 10, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "COV-ABC-1020-01", "120/80", 1, 100, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 35.100000000000001, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Negative", new DateTime(2021, 2, 13, 12, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "COV-ABC-1020-02", "124/79", 1, 92, new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), 36.899999999999999, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Positive", new DateTime(2021, 2, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "COV-ABC-1020-03", "120/80", 1, 91, new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), 37.399999999999999, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Positive", new DateTime(2021, 2, 13, 10, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "COV-ABC-1020-04", "124/79", 1, 93, new DateTime(2021, 2, 15, 8, 19, 0, 0, DateTimeKind.Unspecified), 38.100000000000001, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Positive", new DateTime(2021, 2, 13, 11, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "COV-ABC-1020-05", "120/80", 1, 100, new DateTime(2021, 2, 15, 9, 17, 0, 0, DateTimeKind.Unspecified), 34.5, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Negative", new DateTime(2021, 2, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "COV-ABC-1020-06", "124/79", 1, 91, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 37.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Positive", new DateTime(2021, 2, 13, 13, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "COV-ABC-1030-07", "120/80", 1, 99, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 34.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Negative", new DateTime(2021, 2, 13, 13, 29, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "COV-ABC-1030-08", "124/79", 1, 92, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 38.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Positive", new DateTime(2021, 2, 13, 13, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "COV-ABC-1030-09", "124/79", 1, 94, new DateTime(2021, 3, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 38.5, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Positive", new DateTime(2021, 2, 28, 14, 41, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[,]
                {
                    { 2, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 3, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 4, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 5, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestId", "BarCode", "BloodPressure", "LabUserId", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestId", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 2, "COV-ABC-1010-02", "120/80", 1, 97, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 38.200000000000003, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Positive", new DateTime(2021, 2, 1, 10, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "COV-ABC-1010-03", "124/79", 1, 99, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 34.600000000000001, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Negative", new DateTime(2021, 2, 1, 10, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "COV-ABC-1010-04", "120/80", 1, 99, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 35.799999999999997, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Negative", new DateTime(2021, 2, 1, 11, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "COV-ABC-1010-05", "124/79", 1, 90, new DateTime(2021, 2, 3, 8, 12, 0, 0, DateTimeKind.Unspecified), 37.899999999999999, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Positive", new DateTime(2021, 2, 1, 11, 29, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalendarEvents",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 14);

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

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TestRequests",
                keyColumn: "TestRequestId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dependent",
                keyColumn: "DependentId",
                keyValue: 94);
        }
    }
}
