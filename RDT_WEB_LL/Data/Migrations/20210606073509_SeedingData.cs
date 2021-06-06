using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PossibleAnswers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
