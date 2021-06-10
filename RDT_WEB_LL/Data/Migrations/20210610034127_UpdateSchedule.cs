using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class UpdateSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Schedules",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7f609717-83be-4234-8905-78ae31922922");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "6c341ad4-cb21-4ede-a72c-d111bd2dbf91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76d85667-ff79-4dea-8684-428eb052ebe4", "AQAAAAEAACcQAAAAENE5XnhnW5tAzh9eiKrsvugtEqVS1fo7DuXZY0Ct0VFkecwe/hpGD0+eY629WvD/IA==", "555cf3db-e708-48b7-b4a2-7721317dbaa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38ce90b8-46b3-4a98-af38-ea8df9a01257", "AQAAAAEAACcQAAAAEJFUEvRBpjAzDb/EbIFFR+0Wqx35BTnAGmtGsmDNT0DuFAt+RhG0ztadAJfvkiy3ag==", "f4904188-983f-41d6-9ec7-1c0275d52a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89abc83-45db-47e7-a404-b340b4972950", "AQAAAAEAACcQAAAAELIA1rDbKpFS96/DmsDH5DmrSPFGz4fSKnkEhhnVZWNFBiIJL9ruHTVkoIG96iPHlw==", "774622ea-a800-4658-83c2-38deb6bdce06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c342463-0925-47ac-bb13-f0bf3b4e1d35", "AQAAAAEAACcQAAAAEPVpcnGdWAqcNnVwhBfArEVEGApf1qVfLs/+z0FL6lfhxr6W9Hg3Yg2/MlpuNOT/jw==", "1b3509e8-d5e4-4ac3-9b87-6c6c0d3b4704" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2911ae5-3b1d-47c4-ba47-febd6d35686b", "AQAAAAEAACcQAAAAEP3KVG7KoGRLC5n4ouD2HBQc4VsarZcVM9XZoBmSWoOiVoVRDFKbGOWXF2Y5fu8NQQ==", "48b4eb9f-c520-413f-9ea1-8c8131eca7a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "368c89b3-3765-4118-9566-0ab838984e7c", "AQAAAAEAACcQAAAAEPCRY6ZE+2z5UjEGpNCk+TK/SmnM1gd/dTt6FI3PuCmDI3q5TNiiezoSi1UPyIiizg==", "c030b5af-8a73-43c3-897c-948438553324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8223da1-5e6f-4aac-b84f-a7a31bedec33", "AQAAAAEAACcQAAAAEJPAdKNs0v5wwGsys/xv9/5/V9+VEHoPp9FqvyBF/IzT/q9AbucAqUhUKdmlTg02FA==", "dbee4c6b-f27e-4957-a2a5-c1e17a85de0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ae22b7-bdbe-49c3-9b21-a187b08bf9aa", "AQAAAAEAACcQAAAAEJAXfI9WjPWMF1I7PpnsZ2Gr7EdW2u+bbgaRBF5akyL2fpoCPr7/+fnNhtoIUekTFA==", "b2ac0fbc-790a-44e2-88a3-739803e80318" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2178223a-7f94-4704-aa5b-7af0875203b0", "AQAAAAEAACcQAAAAECLIORo1NXzx64rX6EUQtDrWAEoYNFbLFwtAEeuVXbKoQMPg2l3GYOBc/cUj0l2A/w==", "df3ab92d-5f7e-473e-a4c9-2b22781bbbac" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_UserId",
                table: "Schedules",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_UserId",
                table: "Schedules",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_UserId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_UserId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
    }
}
