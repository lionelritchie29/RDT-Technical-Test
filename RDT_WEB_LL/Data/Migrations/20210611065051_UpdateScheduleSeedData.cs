using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDT_WEB_LL.Data.Migrations
{
    public partial class UpdateScheduleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4ee86b95-4a72-473d-b8c8-11c66e0dfa1f", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c82992f6-cef3-4b71-ac29-785d298abdb5", "PARTICIPANT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4b8d2ff-6d5b-49f0-95c5-8128d10c99b2", "AQAAAAEAACcQAAAAEGodI2zaOJsE7LAm9aKMIZzsepbnJ20fUo1lSqujxgCXAKyQQUABnGyL6Ift5odGvw==", "075032a2-c6f8-44bc-b907-142d3c479887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "582d3c74-a735-4442-b29a-4c85008c3a01", "AQAAAAEAACcQAAAAEKLlwIOfB3jEfyj5NA3Q1+xOZS+5EpAAGuvQnMdwzCZBb160PTZaAKiFZ/Q1AMLj/g==", "ee2180a3-2199-44b0-afeb-df3f32c6c8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64792414-6240-4f4a-a06b-e519464f4fc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ae8bb43-e477-4ec8-be86-d694ba1e828d", "AQAAAAEAACcQAAAAEEcAuwUlBLhAYzTEvU+raFiRbgzND1mdjDddf5j/pfor+vfxA1zKdaAckYNQNxLKZw==", "51450361-7ff2-492c-ac94-fadc18c68d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c17889b-010f-41b3-b8d6-3521a10b1915",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f0ddc1f-3faf-435c-b58e-09be0c4c76e2", "AQAAAAEAACcQAAAAEGSSaMTBBpc2FCW2qYaFvRKzi5/WmJO/ZjcYW6RlCOrt1zE7o7cZBVFqJht6GlLX5w==", "ce83eeb7-3680-4743-ab38-5963e0c0f467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3246f8-2bc5-404b-8212-3a5005c98790",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d27d8e9f-f944-48d3-8b08-bfa0949d24f7", "AQAAAAEAACcQAAAAEE+0+1ZBo6sHKr7rgKytVoE2ouV4BfkSBJtkjtcN2HcqKKquKiRRpdoEG88Ik6xMYA==", "b03cb966-0de4-4d69-a940-70a08a250198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63985bb-0aad-4ba2-abec-2570974c04ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f342eec3-0700-4d22-9e0b-b61eca0773a0", "AQAAAAEAACcQAAAAEPyvh0asJymxoXxhfhVC+3aYzORpAMdeIhEBfpdF9yaesYmvVrr8WVBtEV6TRIRfqA==", "b948842a-75b8-419d-af12-6865c60d7829" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fbdc52d-5c51-47e9-8cdc-ddd2b8349dcf", "AQAAAAEAACcQAAAAEM7/6HEwCWz4uzUbotmjOMBIIc6J589/7lzzoei0rJytYWj9uf06BlgAMFckl5xJWQ==", "8136930b-a98d-4199-a159-cfe17953065c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4abf741e-97bb-4d7e-a476-15f9ef26b96f", "AQAAAAEAACcQAAAAELrfVECOzxo3wTTQkLAB9NlB93Sx+SulHnz6Hcfex0Nxr8cuNJ6AwmnFf/QJlXeSwQ==", "a4586c0a-0796-46be-a7ff-db4718e5aecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0861e36-1df8-4e00-908f-aa20f21bf58f", "AQAAAAEAACcQAAAAEE4AhO9esbR7FTZGQVBEdZUm5Qb5BciDRIOaMk0K57jzGwCma+Osn8VkhKOrrOvBvA==", "e73c1c11-33c5-438a-a208-55a0fc0c1c02" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 11, 19, 50, 50, 94, DateTimeKind.Local).AddTicks(9864), new DateTime(2021, 6, 11, 13, 50, 50, 91, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 50, 50, 95, DateTimeKind.Local).AddTicks(4369), new DateTime(2021, 6, 13, 13, 50, 50, 95, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 12, 1, 50, 50, 95, DateTimeKind.Local).AddTicks(4378), new DateTime(2021, 6, 11, 19, 50, 50, 95, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 11, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 11, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 12, 7, 50, 50, 95, DateTimeKind.Local).AddTicks(4412), new DateTime(2021, 6, 12, 1, 50, 50, 95, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 11, 20, 50, 50, 95, DateTimeKind.Local).AddTicks(4419), new DateTime(2021, 6, 11, 14, 50, 50, 95, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 50, 50, 95, DateTimeKind.Local).AddTicks(4428), new DateTime(2021, 6, 14, 13, 50, 50, 95, DateTimeKind.Local).AddTicks(4425) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b442c7aa-71dd-4ed6-aac0-5bd826328b28", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "participant",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "a87d5ff3-0aa0-41e2-886e-58ea26372d6e", null });

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

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 14, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 11, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 10, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 9, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 8, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 15, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
