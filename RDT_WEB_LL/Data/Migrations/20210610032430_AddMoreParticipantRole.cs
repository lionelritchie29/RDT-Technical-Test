using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class AddMoreParticipantRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7a957f0f-bc21-4d7f-b36f-2326a05a5adb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "424f98fe-cadd-45b9-b33e-504fa410e915");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "participant", "b63985bb-0aad-4ba2-abec-2570974c04ed" },
                    { "participant", "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005" },
                    { "participant", "7c17889b-010f-41b3-b8d6-3521a10b1915" },
                    { "participant", "035c6e49-5ac7-4eb7-8e96-2fee62b29289" },
                    { "participant", "c12807d5-b1cd-45f0-85ee-6a293e07989d" },
                    { "participant", "ff2fd92b-7657-4855-a9b9-70977cd91b3e" },
                    { "participant", "64792414-6240-4f4a-a06b-e519464f4fc0" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f82a51-a573-4dec-be1f-772a5995fa3c", "AQAAAAEAACcQAAAAEJiflqnYFuGhc9JWIdg7IB/EGYHrHWJhDzFpKrbrCm6gjI06Fe/XHGbxa6vp2BV/vQ==", "2c9104eb-1458-4dae-a1e2-98a0c76690aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cc796f5-ec2e-4ce1-8fc3-5ed9be68c2d6", "AQAAAAEAACcQAAAAEEKtE0zUwUZpoisB4k8/iaxB8LCRCNHRW8vdbi1k6KB41Iq7fIaWB1gjGC5fxFiEYg==", "a565c8f0-a93e-4893-bece-3c85af1f388c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6bbc0d2-c7c5-4397-a19b-dfab64e437c9", "AQAAAAEAACcQAAAAELU0h391PGXVSoNz9ypooni++ayCm6oEc7IVuU1/PKtOqbew3CsLWT7KOylhudPh+g==", "972bb125-6654-4bb6-9b3e-bb0cc07050ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead4a404-5f80-4da9-bd93-bfe5afe18397", "AQAAAAEAACcQAAAAEEKstYt7QutAzk/fJlMKgInf7kA7Yd7EqpDKzw129rIzesGc+EAU0f5gt4HBhhgFqQ==", "aa0ab923-fac1-4193-8c20-352c7e137f8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8cb9336-6cfc-4e33-a8ac-73e590960fc3", "AQAAAAEAACcQAAAAEC8kfqMt1vSV/kJk4CmY0qHmSWfgfTTnclouOtzFAUlXATTviBPLYmBfryFngjePlg==", "a9a1b902-5d97-44fe-a290-0e20d6bd0bae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4f70e5-2d7c-43a6-a181-a680df6751c1", "AQAAAAEAACcQAAAAEN6oywZ4D9Yda6sZ4/iR7YQKuRcyVQq7m0/Qe6ELSHPuIdASPe8KmeTazraEuKVOIg==", "4e46964f-a616-47ce-88dd-0c60fa2231ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "495acbec-bb66-4625-832e-d148d36a0b11", "AQAAAAEAACcQAAAAEJuqsFarkFEQ5mSGkbjBkwoI7LK/fxvjMIQCao02fzccKchKwnjY7pywhC5pu96fHw==", "06d5200a-3629-4d68-8fb8-7bd876ceaf17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "860d4c40-975c-4259-ae9e-05ca2e9d645f", "AQAAAAEAACcQAAAAENyYjug/upo+a53b/AtSz4VMjvVMQjelmnrdevbRYlM3jW9IOLKEKmAJiemFsRWlbA==", "80f859be-edec-4984-ab21-498ea87a8751" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3c8694-4612-4777-aa81-d573b75a2f0b", "AQAAAAEAACcQAAAAECM0+zxXNrZSxuCgaTdWIJMONRbDTV7chkKJPeNe8lR6+IBROs7NO5fOj/mh49TC8A==", "322cabc1-2914-4194-89e4-f249d394c27b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "035c6e49-5ac7-4eb7-8e96-2fee62b29289" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "64792414-6240-4f4a-a06b-e519464f4fc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "7c17889b-010f-41b3-b8d6-3521a10b1915" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "b63985bb-0aad-4ba2-abec-2570974c04ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "c12807d5-b1cd-45f0-85ee-6a293e07989d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "participant", "ff2fd92b-7657-4855-a9b9-70977cd91b3e" });

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
    }
}
