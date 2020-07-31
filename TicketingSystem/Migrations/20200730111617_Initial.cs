using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketingSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(nullable: false),
                    ClaimValue = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    isSuperAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Access = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    LookupTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lookups_LookupTypes_LookupTypeId",
                        column: x => x.LookupTypeId,
                        principalTable: "LookupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<int>(nullable: false),
                    AppClaimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleClaims_AppClaims_AppClaimId",
                        column: x => x.AppClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleClaims_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleModules_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserModuleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    AppClaimId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModuleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserModuleClaims_AppClaims_AppClaimId",
                        column: x => x.AppClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserModuleClaims_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserModuleClaims_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserModules_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTeam_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTeam_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue" },
                values: new object[,]
                {
                    { 1, "Create", "create" },
                    { 2, "Read", "read" },
                    { 3, "Update", "update" },
                    { 4, "Delete", "delete" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "isSuperAdmin" },
                values: new object[,]
                {
                    { "0d3347f4-e87c-4cb7-9363-78f89a7ded99", "79917f49-e4b3-403b-a45d-1135b0f91f14", "Imburnal", "IMBURNAL", false },
                    { "9be18648-c958-4ddf-b163-3b84fac5ff3e", "f9b1203c-a5a2-455f-8d95-96c36658d7d3", "Bulalord", "BULALORD", false },
                    { "9bb5e051-ff72-450f-a9ba-2a799aa04fbd", "d9dad3ce-669a-4bc3-ba9c-720bc944c8a5", "Super Sabaw", "SUPER SABAW", true }
                });

            migrationBuilder.InsertData(
                table: "LookupTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 18, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(40), "Module Access", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(35), "Role", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(33), "Channel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(30), "Inquiry Type", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(28), "Call Type", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(25), "Biller", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(18), "Gender", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(20), "Marital Status", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(12), "Ticket Issues", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(7), "Source Channel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(4), "Marketing Campaign", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(1), "Lead Status", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9998), "CRI Teams", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9991), "Email", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(15), "Ticket Status", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9986), "SMS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9877), "Role", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(6217), "Type of Lead", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Access", "Name", "Path" },
                values: new object[,]
                {
                    { 2, "customers", "Customers", null },
                    { 1, "leads", "Leads", null },
                    { 3, "tickets", "Tickets", null },
                    { 4, "maintenance", "Maintenance", null }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(4344), "Luna", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(1159), "Buyani", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(4392), "Saricasa", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupTypeId", "Name", "Sort", "UpdatedBy", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(2551), 1, "Cold Lead", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8729), 10, "Waiting for Someone", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8734), 10, "Waiting for Client", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8736), 10, "For Outbound", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8739), 11, "Male", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8742), 11, "Female", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8745), 11, "Not Specified", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8749), 12, "Single", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8755), 12, "Married", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8758), 12, "Widowed", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8761), 13, "Southlink", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8764), 13, "Saricasa", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8768), 13, "Tienda", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8771), 13, "MIA", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8774), 14, "Inbound", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8777), 14, "Outbound", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8780), 15, "Interest Driven", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8783), 15, "Sales Inquiry", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8787), 15, "Non-Relatable", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8790), 16, "Truckline", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 50, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8793), 16, "FB Messenger", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8796), 16, "Email", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 54, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8806), 17, "Super Admin", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 55, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8810), 17, "Supervisor", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 56, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8813), 17, "VA", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8816), 18, "canEdit", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 58, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8819), 18, "canDelete", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 59, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8823), 18, "canViewAll", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8726), 10, "On-Hold", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 60, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8827), 18, "canCreate", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8723), 10, "Cancelled", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8716), 10, "In progress", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8509), 1, "Warm Lead", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8634), 1, "Hot Lead", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8638), 2, "Admin", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8643), 2, "DSA", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8647), 2, "Agent", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 52, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8800), 2, "Supervisor", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 53, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8803), 2, "Non-Supervisor", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8651), 3, "New Lead", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8654), 3, "Newly Assigned Lead", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8659), 3, "Client", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8662), 4, "New Lead", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8665), 4, "Newly Assigned Lead", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8667), 4, "Client", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8670), 5, "PCFI", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8673), 5, "Cumbria", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8679), 5, "Saricasa", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8702), 6, "New", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8682), 7, "Sample1", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8685), 7, "Sample2", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8688), 7, "Sample3", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8691), 8, "Facebook", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8694), 8, "Instagram", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8699), 8, "Twitter", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8706), 9, "Invalid SOA", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8708), 9, "SOA Adjustment", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8711), 9, "Wrong Payment Details", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8714), 10, "New", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8719), 10, "Resolved", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 61, null, new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8861), 18, "canAssign", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Lookups_LookupTypeId",
                table: "Lookups",
                column: "LookupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleClaims_AppClaimId",
                table: "ModuleClaims",
                column: "AppClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleClaims_ModuleId",
                table: "ModuleClaims",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleModules_ModuleId",
                table: "RoleModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleModules_RoleId",
                table: "RoleModules",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModuleClaims_AppClaimId",
                table: "UserModuleClaims",
                column: "AppClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModuleClaims_AppUserId",
                table: "UserModuleClaims",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModuleClaims_ModuleId",
                table: "UserModuleClaims",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModules_AppUserId",
                table: "UserModules",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModules_ModuleId",
                table: "UserModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeam_AppUserId",
                table: "UserTeam",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeam_TeamId",
                table: "UserTeam",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Lookups");

            migrationBuilder.DropTable(
                name: "ModuleClaims");

            migrationBuilder.DropTable(
                name: "RoleModules");

            migrationBuilder.DropTable(
                name: "UserModuleClaims");

            migrationBuilder.DropTable(
                name: "UserModules");

            migrationBuilder.DropTable(
                name: "UserTeam");

            migrationBuilder.DropTable(
                name: "LookupTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AppClaims");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
