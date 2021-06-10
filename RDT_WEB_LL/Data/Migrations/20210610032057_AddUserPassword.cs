using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class AddUserPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "b4758041-2945-4933-88a3-8de9f719761e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "500c5d6a-0fc5-4af3-943d-8d3fac9f1168");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8f37174-1a27-4f17-8fc2-8ec8cf9d5415", "AQAAAAEAACcQAAAAECxloevBtlJrlAQreBxPRAZ6vWYQeE0ZjJLfZFDYCCKrrD2SLiR7eiJqD2/mwibuig==", "62b9c0d8-3543-43c7-a837-501373227084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bba9576-28a0-4e93-b9c5-d195b2e32da1", "AQAAAAEAACcQAAAAEE7AXAsfiPpFdG/O9JiR9qCp6Ckz392aLzkJv+A1rEmPB/XS4M0PRdcKtW5lu873Bw==", "5762c969-0b11-4947-8169-7b86551f997c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3445ef6f-90b5-4596-b91d-5b99c9e45505", "AQAAAAEAACcQAAAAENb7kHIJ1hYYm+TdWRDgBKNO1GFq0Jbxvw7FBN2XHc5OIlgq+aXHY1FpFsVTPv1Sng==", "6d3853f4-db37-44ee-93d6-395773324f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a564cd-f990-4ff2-acab-f9bf4fa1b879", "AQAAAAEAACcQAAAAEHA3QluSpj/NPqhXvyORCoKSX3CBQpL7jX78LheUoaoa5BcjyOXFk9elVTbvV4bJMA==", "2433b25d-dbcf-43db-9cfa-e5a69b2fed4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8417605d-60b1-44eb-97ec-addac02c5416", "AQAAAAEAACcQAAAAEJDDZf3oIopwkcoZSBlq4+aQ2H+4PiPgHJmddEowruC2qnfYAAQmGIRxP8NBunSMUQ==", "1ecd9d28-6e72-473a-b899-1b352be670d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17416d26-be5c-46a8-837c-b1c633b872f6", "AQAAAAEAACcQAAAAEGxT1QEtyINcO2pfPAWcQbvOe+dbXC2iAJHgoYwO+2Y5XhGwGTJDY0wxGCkyKLgobQ==", "079c7d94-6d67-4e04-8d2a-521eaef0d417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95f2cc2a-0ca1-449d-b6b6-2fe31eaf635e", "AQAAAAEAACcQAAAAELpURosE8ksmTg1LTHOJc5raPnzQ0/o9Fyao7HICD27p5lTvcD2aulp98mGtr3cSFw==", "42053544-d3cd-4710-844d-6ec01f3f8622" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8db0c85f-3541-4d89-b9fa-38f6b5bb8afc", "AQAAAAEAACcQAAAAEEP7v2bRMRkJstIrfnKE0cCDHsG6xBm8pAA01Z5DY8g8+8DLXBRoui0ahtL/9u2RuA==", "b026932f-5750-4519-9bd6-26a628106af7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d902830-c060-46a7-8d70-c5bab5a8272b", "AQAAAAEAACcQAAAAEJOVe3xjTz/N591IoSo1IT80bxxy7Tx9cSbSLiCNlwJmnotfj3J2YLbT77O4r6sPEA==", "425f9004-9292-4134-bc1e-3739796f546e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "9f9437e7-31b6-43f2-ba5e-96a75337ae4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "9cf43b80-8e8c-441a-9fc2-2a7369ce82e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af97693f-f806-4804-b118-315e2d7d5a3a", null, "d7847b54-ad22-4790-bc94-c0e1fff3fb57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b2fe85c-e561-4b5c-a74b-a4b57df2cae3", null, "b861c0cc-2881-4a71-847c-2423f9c652eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6612aa92-130b-4369-adec-746e422fcc4d", null, "4fb5cea1-a849-4f67-ad57-d7747c03e9a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e482b3d7-70e9-46d1-831d-8035e399462b", null, "b63e51d2-788b-4c89-ada0-13d2373e55ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9779f443-333b-4cc5-8f81-cce06b4559eb", null, "80746fec-d980-47b5-bee9-5144ccf37d74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2eb4a7f-0692-42e8-9048-11c8ec22b465", null, "36121fb3-ff7a-44a1-af2f-048fc0f7e151" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b84e6c-0d73-47ed-970b-18b4f0e72f10", null, "77a0fcae-a7ff-4183-86f4-ae5e490ca2f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f583f5-bda3-4d05-b6a6-20f282f49227", null, "1c97e93f-ac25-43f0-9a88-33b6cf50cecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc9b4192-09e0-416e-b953-6967cc922ced", null, "52e97769-7d92-4a31-93b3-e6eb26617d4d" });
        }
    }
}
