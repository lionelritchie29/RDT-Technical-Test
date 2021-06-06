using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class SeedUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "b72b20dc-24d4-4b0e-9f84-38fa5120633a", "Admin", null },
                    { "participant", "a3166b86-a3de-40b0-87bf-d2cb3dd30746", "Participant", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af3246f8-2bc5-404b-8212-3a5005c98790", 0, "ff401096-8d27-44e4-9fb7-2ce9304651fc", "admin@mail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEL3XGVeMIlgdh1r/Z8gq/5J0OZbTFMbxMySs3fI9Qw/GxgqrrgSiV0vQ01g44vDHRQ==", null, false, "758b567f-1ce9-4d57-87eb-d60d72fce6ce", false, "Admin" },
                    { "dc954b45-44ef-4404-b8d6-d502ec9de9ec", 0, "c055af86-0a1b-411c-8a0f-cd58839b2e13", "brandon@mail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEO80JUwNVeudo2IHsmoM4JfngY6YTxhjjyWmNWqEoyajPMxGIWxG1DAeyZqsP5qw4g==", null, false, "d20db892-46d3-4a88-9212-befb7bdd44ae", false, "Brandon Julio" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin", "af3246f8-2bc5-404b-8212-3a5005c98790" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "participant", "dc954b45-44ef-4404-b8d6-d502ec9de9ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin", "af3246f8-2bc5-404b-8212-3a5005c98790" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "dc954b45-44ef-4404-b8d6-d502ec9de9ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec");
        }
    }
}
