using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketingSystem.Migrations
{
    public partial class UserTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeam_AspNetUsers_AppUserId",
                table: "UserTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeam_Teams_TeamId",
                table: "UserTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTeam",
                table: "UserTeam");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d3347f4-e87c-4cb7-9363-78f89a7ded99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bb5e051-ff72-450f-a9ba-2a799aa04fbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be18648-c958-4ddf-b163-3b84fac5ff3e");

            migrationBuilder.RenameTable(
                name: "UserTeam",
                newName: "UserTeams");

            migrationBuilder.RenameIndex(
                name: "IX_UserTeam_TeamId",
                table: "UserTeams",
                newName: "IX_UserTeams_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTeam_AppUserId",
                table: "UserTeams",
                newName: "IX_UserTeams_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTeams",
                table: "UserTeams",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "isSuperAdmin" },
                values: new object[,]
                {
                    { "aaab7e46-00ed-42ca-b3f1-00ba3d7214ef", "f67a4a9b-5e2d-4c3e-a6d2-554c43896fd0", "Super Sabaw", "SUPER SABAW", true },
                    { "d1d3a022-b3db-480f-a4d7-31789bba4df9", "b614b907-c6ef-459d-9b30-a7afe58cdecf", "Bulalord", "BULALORD", false },
                    { "68e50300-dcd8-49e9-ba69-5e7a70c511d0", "37db0358-59c7-4015-a639-8bc9d205d939", "Imburnal", "IMBURNAL", false }
                });

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 552, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 13, 31, 10, 553, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_AspNetUsers_AppUserId",
                table: "UserTeams",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_AspNetUsers_AppUserId",
                table: "UserTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTeams",
                table: "UserTeams");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68e50300-dcd8-49e9-ba69-5e7a70c511d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaab7e46-00ed-42ca-b3f1-00ba3d7214ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1d3a022-b3db-480f-a4d7-31789bba4df9");

            migrationBuilder.RenameTable(
                name: "UserTeams",
                newName: "UserTeam");

            migrationBuilder.RenameIndex(
                name: "IX_UserTeams_TeamId",
                table: "UserTeam",
                newName: "IX_UserTeam_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTeams_AppUserId",
                table: "UserTeam",
                newName: "IX_UserTeam_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTeam",
                table: "UserTeam",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "isSuperAdmin" },
                values: new object[,]
                {
                    { "9bb5e051-ff72-450f-a9ba-2a799aa04fbd", "d9dad3ce-669a-4bc3-ba9c-720bc944c8a5", "Super Sabaw", "SUPER SABAW", true },
                    { "9be18648-c958-4ddf-b163-3b84fac5ff3e", "f9b1203c-a5a2-455f-8d95-96c36658d7d3", "Bulalord", "BULALORD", false },
                    { "0d3347f4-e87c-4cb7-9363-78f89a7ded99", "79917f49-e4b3-403b-a45d-1135b0f91f14", "Imburnal", "IMBURNAL", false }
                });

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 185, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 186, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 30, 11, 16, 16, 187, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeam_AspNetUsers_AppUserId",
                table: "UserTeam",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeam_Teams_TeamId",
                table: "UserTeam",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
