using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CovidXWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "CovidXUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidXUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DependentType",
                columns: table => new
                {
                    DependentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependentType", x => x.DependentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LabUser",
                columns: table => new
                {
                    LabUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabUser", x => x.LabUserId);
                });

            migrationBuilder.CreateTable(
                name: "MedicalAidSchemes",
                columns: table => new
                {
                    MedicalAidSchemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalAidSchemes", x => x.MedicalAidSchemeId);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    NurseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    YearQualified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.NurseId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Suburbs",
                columns: table => new
                {
                    SuburbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuburbName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburbs", x => x.SuburbId);
                    table.ForeignKey(
                        name: "FK_Suburbs_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalAidPlans",
                columns: table => new
                {
                    MedicalAidPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalAidSchemeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalAidPlans", x => x.MedicalAidPlanId);
                    table.ForeignKey(
                        name: "FK_MedicalAidPlans_MedicalAidSchemes_MedicalAidSchemeId",
                        column: x => x.MedicalAidSchemeId,
                        principalTable: "MedicalAidSchemes",
                        principalColumn: "MedicalAidSchemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuburbsPreffereds",
                columns: table => new
                {
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    NurseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuburbsPreffereds", x => new { x.NurseId, x.SuburbId });
                    table.ForeignKey(
                        name: "FK_SuburbsPreffereds_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurses",
                        principalColumn: "NurseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuburbsPreffereds_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonResponsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalAidStatus = table.Column<bool>(type: "bit", nullable: false),
                    MedicalAidPlanId = table.Column<int>(type: "int", nullable: true),
                    MedicalAidNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DependencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_MedicalAidPlans_MedicalAidPlanId",
                        column: x => x.MedicalAidPlanId,
                        principalTable: "MedicalAidPlans",
                        principalColumn: "MedicalAidPlanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                });

            migrationBuilder.CreateTable(
                name: "Dependent",
                columns: table => new
                {
                    DependentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    PersonResponsible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalAidNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalAidStatus = table.Column<bool>(type: "bit", nullable: false),
                    DependentTypeId = table.Column<int>(type: "int", nullable: false),
                    DependencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalAidPlanId = table.Column<int>(type: "int", nullable: true),
                    MainMemberId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependent", x => x.DependentId);
                    table.ForeignKey(
                        name: "FK_Dependent_DependentType_DependentTypeId",
                        column: x => x.DependentTypeId,
                        principalTable: "DependentType",
                        principalColumn: "DependentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependent_MedicalAidPlans_MedicalAidPlanId",
                        column: x => x.MedicalAidPlanId,
                        principalTable: "MedicalAidPlans",
                        principalColumn: "MedicalAidPlanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dependent_Patients_MainMemberId",
                        column: x => x.MainMemberId,
                        principalTable: "Patients",
                        principalColumn: "PatientId");
                    table.ForeignKey(
                        name: "FK_Dependent_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                });

            migrationBuilder.CreateTable(
                name: "TestRequests",
                columns: table => new
                {
                    TestRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DependentId = table.Column<int>(type: "int", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    TestAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    NurseId = table.Column<int>(type: "int", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CalenderEventID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRequests", x => x.TestRequestId);
                    table.ForeignKey(
                        name: "FK_TestRequests_Dependent_DependentId",
                        column: x => x.DependentId,
                        principalTable: "Dependent",
                        principalColumn: "DependentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestRequests_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurses",
                        principalColumn: "NurseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestRequests_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId");
                    table.ForeignKey(
                        name: "FK_TestRequests_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                });

            migrationBuilder.CreateTable(
                name: "CalendarEvents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllDay = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEvents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CalendarEvents_TestRequests_ID",
                        column: x => x.ID,
                        principalTable: "TestRequests",
                        principalColumn: "TestRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NurseSchedules",
                columns: table => new
                {
                    TestRequestId = table.Column<int>(type: "int", nullable: false),
                    NurseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseSchedules", x => new { x.TestRequestId, x.NurseId });
                    table.ForeignKey(
                        name: "FK_NurseSchedules_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurses",
                        principalColumn: "NurseId");
                    table.ForeignKey(
                        name: "FK_NurseSchedules_TestRequests_TestRequestId",
                        column: x => x.TestRequestId,
                        principalTable: "TestRequests",
                        principalColumn: "TestRequestId");
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestRequestId = table.Column<int>(type: "int", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OxygenLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LabUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_Tests_LabUser_LabUserId",
                        column: x => x.LabUserId,
                        principalTable: "LabUser",
                        principalColumn: "LabUserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tests_TestRequests_TestRequestId",
                        column: x => x.TestRequestId,
                        principalTable: "TestRequests",
                        principalColumn: "TestRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 1, "Gqeberha" });

            migrationBuilder.InsertData(
                table: "DependentType",
                columns: new[] { "DependentTypeId", "Description" },
                values: new object[,]
                {
                    { 1001, "Spouse" },
                    { 1002, "Child" },
                    { 1003, "Parent" },
                    { 1004, "Grandparent" },
                    { 1005, "Cousin" },
                    { 1006, "Sibling" },
                    { 1007, "Grandchild" }
                });

            migrationBuilder.InsertData(
                table: "LabUser",
                columns: new[] { "LabUserId", "FirstName", "Idnumber", "LastName", "MobileNumber", "UserID" },
                values: new object[] { 1, "Mandla", "79052520225083", "Khumalo", "0912458796", "b99be5c3-fb63-4c73-b846-83af447ff43e" });

            migrationBuilder.InsertData(
                table: "MedicalAidSchemes",
                columns: new[] { "MedicalAidSchemeId", "Description" },
                values: new object[,]
                {
                    { 1, "BestMed" },
                    { 2, "Bonitas" },
                    { 3, "Discovery Health" }
                });

            migrationBuilder.InsertData(
                table: "Nurses",
                columns: new[] { "NurseId", "FirstName", "Idnumber", "LastName", "MobileNumber", "Rank", "SuburbId", "UserID", "YearQualified" },
                values: new object[,]
                {
                    { 1, "Dorothy", "7503180225083", "Daniels", "0512458796", 2, 126, "7c805a02-1b05-4def-b38d-0a91c402167c", new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Lindile", "7603180225083", "Hadebe", "0522458796", 2, 73, "431f6523-88b4-463e-a09e-6e174e09f6fa", new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Marcel", "7703180225083", "Van Niekerk", "0532458796", 0, 43, "6605428b-3b95-4072-9e26-23b357a21117", new DateTime(2003, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MedicalAidPlans",
                columns: new[] { "MedicalAidPlanId", "Description", "MedicalAidSchemeId" },
                values: new object[,]
                {
                    { 47, "Keycare Core", 3 },
                    { 20, "BonFitComprehensive", 2 },
                    { 19, "BonClassic", 2 },
                    { 18, "BonComplete", 2 },
                    { 17, "BonSave", 2 },
                    { 16, "BonFit Select", 2 },
                    { 15, "Standard Select", 2 },
                    { 14, "Standard", 2 },
                    { 13, "Primary Select", 2 },
                    { 12, "Primary", 2 },
                    { 21, "Hospital Standard", 2 },
                    { 11, "BonStart", 2 },
                    { 9, "Pace 3", 1 },
                    { 8, "Pace 2", 1 },
                    { 7, "Pace 1", 1 },
                    { 6, "Pulse 2", 1 },
                    { 5, "Pulse 1", 1 },
                    { 4, "Beat 4", 1 },
                    { 3, "Beat 3", 1 },
                    { 2, "Beat 2", 1 },
                    { 1, "Beat 1", 1 },
                    { 10, "Pace 4", 1 },
                    { 22, "BonEssential", 2 },
                    { 46, "Keycare Smart", 3 },
                    { 24, "BonCap", 2 },
                    { 23, "BonEssentialSelect", 2 },
                    { 45, "Keycare Plus", 3 },
                    { 44, "Coastal Core", 3 },
                    { 43, "Essential Delta Core", 3 },
                    { 42, "Essential Core", 3 },
                    { 41, "Classic Delta Core", 3 },
                    { 39, "Essential Smart", 3 },
                    { 38, "Classic Smart", 3 },
                    { 37, "Coastal Saver", 3 },
                    { 36, "Essential Delta Saver", 3 },
                    { 40, "Classic Core", 3 },
                    { 34, "Classic Delta Saver", 3 },
                    { 33, "Classic Saver", 3 },
                    { 32, "Essential Priority", 3 },
                    { 31, "Classic Priority", 3 },
                    { 25, "Executive", 3 },
                    { 30, "Essential Data", 3 }
                });

            migrationBuilder.InsertData(
                table: "MedicalAidPlans",
                columns: new[] { "MedicalAidPlanId", "Description", "MedicalAidSchemeId" },
                values: new object[,]
                {
                    { 29, "Essential Comprehensive", 3 },
                    { 28, "Classic Smart Comprehensive", 3 },
                    { 27, "Classic Data Comprehensive", 3 },
                    { 26, "Classic Comprehensive", 3 },
                    { 35, "Essential Saver", 3 }
                });

            migrationBuilder.InsertData(
                table: "Suburbs",
                columns: new[] { "SuburbId", "CityId", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 113, 1, "6059", "Saltville" },
                    { 114, 1, "6059", "Sanctor" },
                    { 115, 1, "6020", "Schauderville" },
                    { 120, 1, "6020", "Springdale" },
                    { 117, 1, "6025", "Sherwood" },
                    { 118, 1, "6001", "Sidwell" },
                    { 119, 1, "6001", "South End" },
                    { 112, 1, "6059", "Salt Lake" },
                    { 116, 1, "6070", "Sea View" },
                    { 111, 1, "6059", "Salsoneville" },
                    { 100, 1, "6001", "Parsons Hill" },
                    { 109, 1, "6001", "Rufanevale" },
                    { 108, 1, "6025", "Rowallan Park" },
                    { 107, 1, "6001", "Richmond Park" },
                    { 106, 1, "6001", "Richmond Hill" },
                    { 105, 1, "6001", "Retiefville" },
                    { 104, 1, "6201", "Redhouse" },
                    { 103, 1, "6070", "Providentia" },
                    { 102, 1, "6070", "Pinegrove" },
                    { 101, 1, "6001", "Perridgevale" },
                    { 121, 1, "6070", "Springfield" },
                    { 99, 1, "6025", "Parsons Vlei" },
                    { 110, 1, "6070", "Salisbury Park" },
                    { 122, 1, "6001", "ST Georges" },
                    { 133, 1, "6059", "Timothy Valley" },
                    { 124, 1, "6001", "Steytler" },
                    { 147, 1, "6201", "Zwide" },
                    { 146, 1, "6001", "Young Park" },
                    { 98, 1, "6020", "Parkside" },
                    { 144, 1, "6070", "Woodlands" },
                    { 143, 1, "6070", "Weybridge Park" },
                    { 142, 1, "6045", "Westview" },
                    { 141, 1, "6025", "Westering" },
                    { 140, 1, "6211", "Wells Estate" },
                    { 139, 1, "6070", "Walmer Heights" },
                    { 138, 1, "6070", "Walmer Downs" },
                    { 123, 1, "6045", "Stella Londt Park" }
                });

            migrationBuilder.InsertData(
                table: "Suburbs",
                columns: new[] { "SuburbId", "CityId", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 137, 1, "6070", "Walmer" },
                    { 135, 1, "6070", "Trevolen" },
                    { 134, 1, "6025", "Treehaven" },
                    { 132, 1, "6070", "Theescombe" },
                    { 131, 1, "6025", "Taybank" },
                    { 130, 1, "6001", "Sydenham" },
                    { 129, 1, "6210", "Swartkops" },
                    { 128, 1, "6045", "Sunridge Park" },
                    { 127, 1, "6001", "Summerwood" },
                    { 126, 1, "6001", "Summerstrand" },
                    { 125, 1, "6001", "Struandale" },
                    { 136, 1, "6025", "Vikingvale" },
                    { 145, 1, "6020", "Woolhope" },
                    { 97, 1, "6001", "Park Drive" },
                    { 95, 1, "6059", "Palm Ridge" },
                    { 26, 1, "6045", "Cotswold" },
                    { 27, 1, "6001", "Cradock Place" },
                    { 28, 1, "6001", "Cradockplek" },
                    { 29, 1, "6001", "Craigbain" },
                    { 30, 1, "6025", "Crestview" },
                    { 31, 1, "6059", "Dowerville" },
                    { 32, 1, "6070", "Emerald Hill" },
                    { 33, 1, "6070", "Essexvale" },
                    { 34, 1, "6070", "Fairview" },
                    { 25, 1, "6001", "Collen Glen" },
                    { 35, 1, "6045", "Ferguson" },
                    { 37, 1, "6059", "Fernwood Park" },
                    { 38, 1, "6001", "Forest Hill" },
                    { 39, 1, "6045", "Framesby" },
                    { 40, 1, "6045", "Francis Evatt Park" },
                    { 41, 1, "6025", "Gambleville" },
                    { 42, 1, "6020", "Gelvan Park" },
                    { 43, 1, "6020", "Gelvandale" },
                    { 44, 1, "6045", "Glen Hurd" },
                    { 45, 1, "6025", "Glen Kamma" },
                    { 36, 1, "6045", "Fernglen" },
                    { 46, 1, "6001", "Gledinningvale" },
                    { 24, 1, "6059", "Cleary Park" },
                    { 22, 1, "6070", "Charlo" },
                    { 2, 1, "6001", "Algoa Park" },
                    { 3, 1, "6059", "Arcadia" },
                    { 4, 1, "6059", "Aspen Heights" }
                });

            migrationBuilder.InsertData(
                table: "Suburbs",
                columns: new[] { "SuburbId", "CityId", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 5, 1, "6025", "Ben Kamma" },
                    { 6, 1, "6059", "Bethelsdorp" },
                    { 7, 1, "6070", "Beverly Grove" },
                    { 8, 1, "6020", "Beverly Hills" },
                    { 9, 1, "6059", "Bloemendal" },
                    { 10, 1, "6210", "Bluewater BAY" },
                    { 23, 1, "6059", "Chatty" },
                    { 11, 1, "6200", "Boast Village" },
                    { 13, 1, "6025", "Bramhope" },
                    { 14, 1, "6025", "Brentwood Park" },
                    { 15, 1, "6025", "Bridgemead" },
                    { 16, 1, "6070", "Broadwood" },
                    { 17, 1, "6025", "Brymore" },
                    { 18, 1, "6001", "Cadles" },
                    { 19, 1, "6001", "Castle Hill" },
                    { 20, 1, "6001", "Centralhil" },
                    { 21, 1, "6001", "Central" },
                    { 12, 1, "6059", "Booysens Park" },
                    { 47, 1, "6025", "Glenroy Park" },
                    { 48, 1, "6070", "Goldwater" },
                    { 49, 1, "6045", "Greenacres" },
                    { 75, 1, "6070", "Lovemore Heights" },
                    { 76, 1, "6070", "Lovemore Park" },
                    { 77, 1, "6001", "Macleanville" },
                    { 78, 1, "6020", "Malabar" },
                    { 79, 1, "6070", "Mangold Park" },
                    { 80, 1, "6200", "Mcnamee Village" },
                    { 81, 1, "6001", "Mill Park" },
                    { 82, 1, "6001", "Millard Grange" },
                    { 83, 1, "6070", "Miramar" },
                    { 74, 1, "6070", "Lorraine Manor" },
                    { 84, 1, "6059", "Missionvale" },
                    { 86, 1, "6025", "Morningside" },
                    { 87, 1, "6001", "Motherwell" },
                    { 88, 1, "6001", "Mount Croix" },
                    { 89, 1, "6070", "Mount Pleasant" },
                    { 90, 1, "6001", "Neave" },
                    { 91, 1, "6200", "New Brighton" },
                    { 92, 1, "6045", "Newton Park" },
                    { 93, 1, "6059", "Normanville" },
                    { 94, 1, "6001", "North End" },
                    { 85, 1, "6025", "Moregrove" }
                });

            migrationBuilder.InsertData(
                table: "Suburbs",
                columns: new[] { "SuburbId", "CityId", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 73, 1, "6070", "Lorraine" },
                    { 72, 1, "6001", "Listerwood" },
                    { 71, 1, "6025", "Linton Grange" },
                    { 50, 1, "6001", "Greenbushes" },
                    { 51, 1, "6070", "Greenshields Park" },
                    { 52, 1, "6059", "Heath Park" },
                    { 53, 1, "6020", "Helenvale" },
                    { 54, 1, "6059", "Hillside" },
                    { 55, 1, "6001", "Holland Park" },
                    { 56, 1, "6001", "Humerail" },
                    { 57, 1, "6001", "Humewood" },
                    { 58, 1, "6025", "Hunters Retreat" },
                    { 59, 1, "6025", "Kabega" },
                    { 60, 1, "6070", "Kamma Creek" },
                    { 61, 1, "6070", "Kamma Park" },
                    { 62, 1, "6025", "Kamma Ridge" },
                    { 63, 1, "6211", "Kamvelihle" },
                    { 64, 1, "6001", "Kemsley Park" },
                    { 65, 1, "6001", "Kensington" },
                    { 66, 1, "6020", "Korsten" },
                    { 67, 1, "6025", "Kunene Park" },
                    { 68, 1, "6200", "Kwaford" },
                    { 69, 1, "6205", "Kwazakhele" },
                    { 70, 1, "6001", "Linkside" },
                    { 96, 1, "6070", "Pari Park" },
                    { 1, 1, "6001", "Adcock Vale" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "AddressLine1", "AddressLine2", "DependencyCode", "Dob", "FirstName", "Gender", "Idnumber", "LastName", "MedicalAidNo", "MedicalAidPlanId", "MedicalAidStatus", "MobileNumber", "PersonResponsible", "SuburbId", "UserID" },
                values: new object[,]
                {
                    { 3, "1 Harbor Cottages", "Sayre Crescent", null, new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", 1, "8002200225083", "Greeff", null, null, false, "0712458796", "David Greeff", 56, "c6b10bd1-3b3d-471d-bc80-6124281b0ac1" },
                    { 1, "19 Admirality Way", null, "00", new DateTime(1955, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charmaine", 0, "5503180225083", "Meintjies", "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126, "03cec2e5-888a-4a7c-a435-03eb22b0fbe6" },
                    { 12, "45 Columbia Crescent", null, "00", new DateTime(1991, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulane", 0, "9110120225083", "Masemola", "465465885", 1, true, "0642458796", "Pulane Masemola", 84, "bc6d851f-4321-4b32-86ec-6a305f3d77bb" },
                    { 6, "28 7th Avenue", null, null, new DateTime(1975, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felicity", 0, "7512020225083", "Daniels", null, null, false, "0612458796", "Felicity Daniels", 127, "391f693d-644d-4935-95ae-c8e50062b987" },
                    { 2, "24 7th Avenue", null, null, new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob", 1, "8012010225083", "Moloi", null, null, false, "0822458796", "Jacob Moloi", 127, "4021c065-e9dc-4eac-a55a-c4da9aa92ff3" },
                    { 8, "12 Marshall Road", null, "00", new DateTime(1964, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alyce", 0, "6412120225083", "Morapedi", "395465885", 17, true, "0632458796", "Alyce Morapedi", 57, "1320196b-a77c-429c-b10e-bd2260e3979c" },
                    { 5, "6 Rubin Crescent", null, null, new DateTime(1985, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karien", 0, "8509020225083", "Momberg", null, null, false, "0732458796", "Karien Momberg", 126, "67395a1f-9011-4a3d-8c07-efec7d97b240" },
                    { 10, "29 Peace Street", null, null, new DateTime(1950, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", 1, "5008100225083", "Perestrelo", null, null, false, "0842458796", "Carlos Perestrelo", 84, "42412d47-3da8-4e21-beef-83555c3a7186" },
                    { 4, "27 Aspen Complex", "La Roche Drive", null, new DateTime(1976, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kopano", 1, "7606030225083", "Sithole", null, null, false, "0722458796", "Kopano Sithole", 57, "e36685da-9d7e-4caf-8cb8-b51962676845" },
                    { 7, "37 The Beaches", "Beach Road", null, new DateTime(1960, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Errol", 1, "6008090225083", "Pieterse", null, null, false, "0612458796", "Errol Pieterse", 56, "233ca6e9-9697-4f03-9b01-d20e4db76b41" },
                    { 11, "7 Jacks Road", null, null, new DateTime(1971, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kabelo", 1, "7112150225083", "Padi", null, null, false, "0742458796", "Kabelo Padi", 84, "30fb49a6-9b10-468b-9181-457568111ae1" },
                    { 9, "13 Congo Avenue", null, "00", new DateTime(1983, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asha", 0, "8302090225083", "Sharma", "175465885", 44, true, "0812458796", "Asha Sharma", 84, "def67f92-1208-48d3-a001-fd66ed0ed827" }
                });

            migrationBuilder.InsertData(
                table: "SuburbsPreffereds",
                columns: new[] { "NurseId", "SuburbId" },
                values: new object[,]
                {
                    { 3, 91 },
                    { 1, 126 },
                    { 1, 57 },
                    { 1, 127 },
                    { 1, 56 }
                });

            migrationBuilder.InsertData(
                table: "Dependent",
                columns: new[] { "DependentId", "AddressLine1", "AddressLine2", "DependencyCode", "DependentTypeId", "Dob", "FirstName", "Gender", "Idnumber", "LastName", "MainMemberId", "MedicalAidNo", "MedicalAidPlanId", "MedicalAidStatus", "MobileNumber", "PersonResponsible", "SuburbId" },
                values: new object[,]
                {
                    { 96, "24 7th Avenue", null, null, 1007, new DateTime(2011, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thabo", 1, "1107090225083", "Moloi", 2, null, null, false, "0822458796", "Jacob Moloi", 127 },
                    { 94, "19 Admirality Way", null, null, 1006, new DateTime(1953, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", 1, "5309130225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 93, "19 Admirality Way", null, null, 1007, new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vanessa", 0, "1607070225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 92, "19 Admirality Way", null, null, 1007, new DateTime(2012, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vince", 1, "1205050225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 91, "19 Admirality Way", null, null, 1006, new DateTime(1958, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dalene", 0, "5803180224083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126 },
                    { 95, "24 7th Avenue", null, null, 1002, new DateTime(1983, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lesedi", 0, "8307070225083", "Moloi", 2, null, null, false, "0772458796", "Jacob Moloi", 127 }
                });

            migrationBuilder.InsertData(
                table: "TestRequests",
                columns: new[] { "TestRequestId", "CalenderEventID", "DateAssigned", "DependentId", "EndTime", "NurseId", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbId", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 26, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 8, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 57, "12 Marshall Road", null },
                    { 11, null, null, null, null, null, 8, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "12 Marshall Road", null },
                    { 16, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "19 Admirality Way", null },
                    { 1, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 126, "19 Admirality Way", null },
                    { 30, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 12, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 84, "45 Columbia Crescent", null },
                    { 15, null, null, null, null, null, 12, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "45 Columbia Crescent", null },
                    { 24, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 6, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 127, "28 7th Avenue", null },
                    { 9, null, null, null, null, null, 6, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 127, "28 7th Avenue", null },
                    { 6, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 3, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 23, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 5, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "6 Rubin Crescent", null },
                    { 8, null, null, null, null, null, 5, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 126, "6 Rubin Crescent", null },
                    { 29, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 11, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 84, "7 Jacks Road", null },
                    { 14, null, null, null, null, null, 11, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "7 Jacks Road", null },
                    { 28, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 10, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 84, "29 Peace Street", null },
                    { 13, null, null, null, null, null, 10, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "29 Peace Street", null },
                    { 22, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 4, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 57, "27 Aspen Complex", "La Roche Drive" },
                    { 7, null, null, null, null, null, 4, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "27 Aspen Complex", "La Roche Drive" },
                    { 25, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 7, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 56, "37 The Beaches", "Beach Road" },
                    { 10, null, null, null, null, null, 7, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 56, "37 The Beaches", "Beach Road" },
                    { 21, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 3, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 12, null, null, null, null, null, 9, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "13 Congo Avenue", null },
                    { 27, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 9, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 84, "13 Congo Avenue", null }
                });

            migrationBuilder.InsertData(
                table: "TestRequests",
                columns: new[] { "TestRequestId", "CalenderEventID", "DateAssigned", "DependentId", "EndTime", "NurseId", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbId", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, null, 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 126, "19 Admirality Way", null },
                    { 17, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, null, 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "19 Admirality Way", null },
                    { 3, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, null, 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 126, "19 Admirality Way", null },
                    { 18, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, null, 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "19 Admirality Way", null },
                    { 4, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, null, 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 126, "19 Admirality Way", null },
                    { 19, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, null, 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "19 Admirality Way", null },
                    { 5, null, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, null, 1, 1, new DateTime(2021, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 126, "19 Admirality Way", null },
                    { 20, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, null, 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 126, "19 Admirality Way", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_DependentTypeId",
                table: "Dependent",
                column: "DependentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_MainMemberId",
                table: "Dependent",
                column: "MainMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_MedicalAidPlanId",
                table: "Dependent",
                column: "MedicalAidPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_SuburbId",
                table: "Dependent",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalAidPlans_MedicalAidSchemeId",
                table: "MedicalAidPlans",
                column: "MedicalAidSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseSchedules_NurseId",
                table: "NurseSchedules",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalAidPlanId",
                table: "Patients",
                column: "MedicalAidPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SuburbId",
                table: "Patients",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_Suburbs_CityId",
                table: "Suburbs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SuburbsPreffereds_SuburbId",
                table: "SuburbsPreffereds",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequests_DependentId",
                table: "TestRequests",
                column: "DependentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequests_NurseId",
                table: "TestRequests",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequests_PatientId",
                table: "TestRequests",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequests_SuburbId",
                table: "TestRequests",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_LabUserId",
                table: "Tests",
                column: "LabUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestRequestId",
                table: "Tests",
                column: "TestRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarEvents");

            migrationBuilder.DropTable(
                name: "CovidXUser");

            migrationBuilder.DropTable(
                name: "NurseSchedules");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SuburbsPreffereds");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "LabUser");

            migrationBuilder.DropTable(
                name: "TestRequests");

            migrationBuilder.DropTable(
                name: "Dependent");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "DependentType");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "MedicalAidPlans");

            migrationBuilder.DropTable(
                name: "Suburbs");

            migrationBuilder.DropTable(
                name: "MedicalAidSchemes");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
