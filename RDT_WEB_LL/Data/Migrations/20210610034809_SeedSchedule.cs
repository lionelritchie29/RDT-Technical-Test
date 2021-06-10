using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class SeedSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "812673be-38fe-48c5-9936-7696ba8086c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "271ab109-588f-4b34-b757-71e72198b3a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7cc408b-560a-4b51-8486-ecea42f1064d", "AQAAAAEAACcQAAAAEIMX8E4GL3k2Cg84ivn3Kq5LNuZJw5mn85X3P9evhfvJfPUT4g3dk0wigil5SqVURA==", "f6e22764-3242-403d-adf2-973a8b9250d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc56a5ce-9a68-490e-94b0-3e29415c3ce1", "AQAAAAEAACcQAAAAELQqGJViZ+77CB5VjEB98JmMF/Dp8jWfxNaotQqRl7YlZsRb1/QVd4szr3034t2h2g==", "9eca7138-a452-4b91-a8dd-d982d7ddd13d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47e0ffba-f3c5-4ca1-9515-84251b977c87", "AQAAAAEAACcQAAAAELEEx0TC+KhuJn+Owh3z+UBrWQMxIfFG0FfwvOAEHPfKpwbCbdqsqMgwWA5VcJToBA==", "350c7ed9-4996-43bd-86ec-dadc7b5ae1cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528ad953-5962-41bb-a83d-46744c8462df", "AQAAAAEAACcQAAAAENlE56QRkAVPs30e2Z0YCNWtqqsNCDAPkVyLGvo2X4hceSaAVD326/wL6KNXzhWLXg==", "b3284933-4331-4e06-a100-927701fc881c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776a4362-f185-45a3-9df2-8ec1b6b022cb", "AQAAAAEAACcQAAAAEMa30i7b8M9KZANxCqxExlRM5qJFvPleb5bEg3Wp8sL+Ravm+yqOM56xXczJmh1Pyg==", "7483b490-7d59-49a1-9ddb-d454de96aa5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af700a2c-899e-4023-a98b-54cf1471fe51", "AQAAAAEAACcQAAAAENcujXENGwSDOVMcwpz2EH96GCIUoNrZW9Bn8bTOQNKk6GRPJqJt5PFHOimN9I/lvA==", "8fb9e12a-787f-4901-8a83-9de6a6f70ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba1f37f-d9b9-442c-8958-a3d457664d0a", "AQAAAAEAACcQAAAAEK9dMuPR4B48T3Q9OD3kYS6LhwWK22tIVtCKE1owHkJXA99f1DEeE13027dwsKeMyQ==", "a778a41b-f5ea-458e-ac1d-b61c64552b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27fd22d2-fe2a-47d2-bd90-d64cb8d1729a", "AQAAAAEAACcQAAAAEAIxxMPWMn3dozVH6m+E3P1kZsCuuV1M33dy+aIs3azq5ZTlz+tD1edNdoZocJFlZA==", "d7a0564d-6767-4783-a7ee-1b7633d3b053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f097446-f7b1-43bc-97ad-c3e09deae1a1", "AQAAAAEAACcQAAAAEPxXJHmU206mrDBHbqnFH8y0w//Bgr1BrIt6fj9dFS2ynCImqtD1Bwmf4nVdtrLuGg==", "4f97bed1-eae9-4801-b434-1d8d419bc64b" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Status", "UserId", "endDate", "startDate" },
                values: new object[,]
                {
                    { 7, "", "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005", new DateTime(2021, 6, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 15, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 6, "", "64792414-6240-4f4a-a06b-e519464f4fc0", new DateTime(2021, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 8, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 5, "", "035c6e49-5ac7-4eb7-8e96-2fee62b29289", new DateTime(2021, 6, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 9, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 4, "", "c12807d5-b1cd-45f0-85ee-6a293e07989d", new DateTime(2021, 6, 10, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 15, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "", "ff2fd92b-7657-4855-a9b9-70977cd91b3e", new DateTime(2021, 6, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 11, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "", "7c17889b-010f-41b3-b8d6-3521a10b1915", new DateTime(2021, 6, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 14, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 8, "", "b63985bb-0aad-4ba2-abec-2570974c04ed", new DateTime(2021, 6, 10, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local) },
                    { 1, "", "dc954b45-44ef-4404-b8d6-d502ec9de9ec", new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 12, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

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
        }
    }
}
