using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class CreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasCorrectAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PossibleAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PossibleAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PossibleAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => new { x.UserId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_UserAnswers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "9f9437e7-31b6-43f2-ba5e-96a75337ae4f", "Admin", null },
                    { "participant", "9cf43b80-8e8c-441a-9fc2-2a7369ce82e9", "Participant", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af3246f8-2bc5-404b-8212-3a5005c98790", 0, "9779f443-333b-4cc5-8f81-cce06b4559eb", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", null, null, false, "80746fec-d980-47b5-bee9-5144ccf37d74", false, "admin@mail.com" },
                    { "dc954b45-44ef-4404-b8d6-d502ec9de9ec", 0, "d5f583f5-bda3-4d05-b6a6-20f282f49227", "brandon@mail.com", false, false, null, "BRANDON@MAIL.COM", "BRANDON@MAIL.COM", null, null, false, "1c97e93f-ac25-43f0-9a88-33b6cf50cecd", false, "brandon@mail.com" },
                    { "7c17889b-010f-41b3-b8d6-3521a10b1915", 0, "e482b3d7-70e9-46d1-831d-8035e399462b", "stanley@mail.com", false, false, null, "STANLEY@MAIL.COM", "STANLEY@MAIL.COM", null, null, false, "b63e51d2-788b-4c89-ada0-13d2373e55ee", false, "stanley@mail.com" },
                    { "ff2fd92b-7657-4855-a9b9-70977cd91b3e", 0, "cc9b4192-09e0-416e-b953-6967cc922ced", "clarissa@mail.com", false, false, null, "CLARISSA@MAIL.COM", "CLARISSA@MAIL.COM", null, null, false, "52e97769-7d92-4a31-93b3-e6eb26617d4d", false, "clarissa@mail.com" },
                    { "c12807d5-b1cd-45f0-85ee-6a293e07989d", 0, "52b84e6c-0d73-47ed-970b-18b4f0e72f10", "gaby@mail.com", false, false, null, "GABY@MAIL.COM", "GABY@MAIL.COM", null, null, false, "77a0fcae-a7ff-4183-86f4-ae5e490ca2f8", false, "gaby@mail.com" },
                    { "035c6e49-5ac7-4eb7-8e96-2fee62b29289", 0, "af97693f-f806-4804-b118-315e2d7d5a3a", "cleo@mail.com", false, false, null, "CLEO@MAIL.COM", "CLEO@MAIL.COM", null, null, false, "d7847b54-ad22-4790-bc94-c0e1fff3fb57", false, "cleo@mail.com" },
                    { "64792414-6240-4f4a-a06b-e519464f4fc0", 0, "6612aa92-130b-4369-adec-746e422fcc4d", "vincent@mail.com", false, false, null, "VINCENT@MAIL.COM", "VINCENT@MAIL.COM", null, null, false, "4fb5cea1-a849-4f67-ad57-d7747c03e9a0", false, "vincent@mail.com" },
                    { "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005", 0, "2b2fe85c-e561-4b5c-a74b-a4b57df2cae3", "jepe@mail.com", false, false, null, "JEPE@MAIL.COM", "JEPE@MAIL.COM", null, null, false, "b861c0cc-2881-4a71-847c-2423f9c652eb", false, "jepe@mail.com" },
                    { "b63985bb-0aad-4ba2-abec-2570974c04ed", 0, "c2eb4a7f-0692-42e8-9048-11c8ec22b465", "onel@mail.com", false, false, null, "ONEL@MAIL.COM", "ONEL@MAIL.COM", null, null, false, "36121fb3-ff7a-44a1-af2f-048fc0f7e151", false, "onel@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Multiple choice" },
                    { 2, "Boolean" },
                    { 3, "Select from list" },
                    { 4, "Essay" },
                    { 5, "File Upload" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "admin", "af3246f8-2bc5-404b-8212-3a5005c98790" },
                    { "participant", "dc954b45-44ef-4404-b8d6-d502ec9de9ec" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "HasCorrectAnswer", "QuestionText", "QuestionTypeId" },
                values: new object[,]
                {
                    { 2, true, "Apa ideologi yang dianut oleh Indonesia ?", 1 },
                    { 4, true, "Dalam kehidupan bernegara Pancasila berperan sebagai ?", 1 },
                    { 1, true, "Soekarno adalah presiden pertama Indonesia", 2 },
                    { 5, true, "Hari lahir pancasila diperingati setiap tanggal 2 Juni", 2 },
                    { 3, true, "Siapa president ketiga Republik Indonesia ?", 3 },
                    { 6, false, "Sebutkan alinea kesatu pembukaan UUD 1945", 4 },
                    { 7, false, "Tuliskan rumusan awal Pancasila berdasarkan Piagam Jakarta di sebuah kertas. Kemudian foto, lalu upload melalui form dibawah.", 5 }
                });

            migrationBuilder.InsertData(
                table: "PossibleAnswers",
                columns: new[] { "Id", "Answer", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 3, "Pancasila", true, 2 },
                    { 10, "Megawati Soekarnoputri", false, 3 },
                    { 9, "Abdurrahman Wahid", false, 3 },
                    { 8, "BJ Habibie", true, 3 },
                    { 7, "Soeharto", false, 3 },
                    { 6, "Soekarno", false, 3 },
                    { 17, "false", true, 5 },
                    { 11, "Susilo Bambang Yudhoyono", false, 3 },
                    { 16, "true", false, 5 },
                    { 1, "true", true, 1 },
                    { 15, "Tidak berperan sebagai apa - apa", false, 4 },
                    { 14, "Pajangan", false, 4 },
                    { 13, "Dasar Negara", true, 4 },
                    { 5, "UUD 1945", false, 2 },
                    { 4, "Trisila", false, 2 },
                    { 2, "false", false, 1 },
                    { 12, "Joko Widodo", false, 3 }
                });  

            migrationBuilder.CreateIndex(
                name: "IX_PossibleAnswers_QuestionId",
                table: "PossibleAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuestionId",
                table: "UserAnswers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PossibleAnswers");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionTypes");
        }
    }
}
