using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class AddScheduleTakenOnDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TakenOn",
                table: "Schedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "b442c7aa-71dd-4ed6-aac0-5bd826328b28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                column: "ConcurrencyStamp",
                value: "a87d5ff3-0aa0-41e2-886e-58ea26372d6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b23b034d-8691-4708-8ceb-dae31b2e5ffc", "AQAAAAEAACcQAAAAEDfZ0Y9H7b9yytx5PBrzwNyKlEwVecuampSYcyPqMg///mHqfEGlrVNP1VDcSQMdlw==", "67b4cd4d-3fbc-4eab-b35b-561bab11ed7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80792805-8366-4966-9fca-4a4cc2e96fd9", "AQAAAAEAACcQAAAAEPNacUHl4tdnazfdCBU6w5yzZZW8YbbVrx/gTWoHVe9OBjZzpJCVCTRc78/olkyyxg==", "2db92e60-cb14-4b3c-ad59-ff4e2c3bccfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6301c47f-f942-426b-b152-2b4f8fa75555", "AQAAAAEAACcQAAAAEA6AmLdvJapaOpBn7ar7Y5qXCxX9BUBJ8UZUFFe52c15JOXS69HSr55j5CR2Xm8pDg==", "d82a7964-d4a0-41d4-877b-1519f3e750de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05fc71bb-dac2-4244-93b3-7a264e12b96f", "AQAAAAEAACcQAAAAELS+oHkzxonv0FMvurDOP7FsUOvK0V0H2ratjIWDbdQMJGK53GxYqTW3vA7/Be3coQ==", "77e75b9d-3298-4c9a-9fdd-ce844228c4e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a91fa8b-311e-48b3-8570-e769631d48b7", "AQAAAAEAACcQAAAAEBvHmnagDlbqnm5bjaZyQN/4PEbZlu6PdoZJkSFgI1AG8M0SGw2Zcksx0YAHNTW4bw==", "e04322c9-02f7-4102-8c5c-a72bad68e114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ce0b830-d382-4078-b00e-ba72048c490b", "AQAAAAEAACcQAAAAEFivPreO7UfCOjdDC9TkaOfrd8E4fVxSKL5xd/1zuD9OD3kwDOX2VmRUjorCiT09Tw==", "fda842e8-50dc-4190-9e01-f23f185afd65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55ad33ff-284d-4f89-ac2e-59548e199d38", "AQAAAAEAACcQAAAAEEhFt+fSBOFJxFRMMokpOy9lxHgMamr19mlNL1pPi8rJce9qsgQEnH6GvXl0iiVU6g==", "200be417-c8be-4482-819e-b479c39ce15c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2351ad9e-1047-4d9d-93f1-e089abca873c", "AQAAAAEAACcQAAAAEE7RxXnJqwXFWt9RKdcLGU3kENMc6BrHN4tXZmj+mEt97oGXhOcTLVtEs+6gNfAC9A==", "8db5ee10-67b5-495a-9fc6-82568b96f329" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c2125c-9a9b-4196-ba24-4fe4b79962f1", "AQAAAAEAACcQAAAAEI1yUgqTyx7hlO05U264k9M19BxKBDJ3aSXo1pzZAIFkROTgwzPHTgARPOnIEnquUw==", "bf33da58-5a4d-4f1d-8537-612cca952ea8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakenOn",
                table: "Schedules");

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
        }
    }
}
