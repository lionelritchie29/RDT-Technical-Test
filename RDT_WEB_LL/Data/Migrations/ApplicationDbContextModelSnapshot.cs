﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RDT_WEB_LL.Data;

namespace RDT_WEB_LL.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "b442c7aa-71dd-4ed6-aac0-5bd826328b28",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "participant",
                            ConcurrencyStamp = "a87d5ff3-0aa0-41e2-886e-58ea26372d6e",
                            Name = "Participant"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "af3246f8-2bc5-404b-8212-3a5005c98790",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a91fa8b-311e-48b3-8570-e769631d48b7",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBvHmnagDlbqnm5bjaZyQN/4PEbZlu6PdoZJkSFgI1AG8M0SGw2Zcksx0YAHNTW4bw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e04322c9-02f7-4102-8c5c-a72bad68e114",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2351ad9e-1047-4d9d-93f1-e089abca873c",
                            Email = "brandon@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BRANDON@MAIL.COM",
                            NormalizedUserName = "BRANDON@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE7RxXnJqwXFWt9RKdcLGU3kENMc6BrHN4tXZmj+mEt97oGXhOcTLVtEs+6gNfAC9A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8db5ee10-67b5-495a-9fc6-82568b96f329",
                            TwoFactorEnabled = false,
                            UserName = "brandon@mail.com"
                        },
                        new
                        {
                            Id = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "05fc71bb-dac2-4244-93b3-7a264e12b96f",
                            Email = "stanley@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STANLEY@MAIL.COM",
                            NormalizedUserName = "STANLEY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELS+oHkzxonv0FMvurDOP7FsUOvK0V0H2ratjIWDbdQMJGK53GxYqTW3vA7/Be3coQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "77e75b9d-3298-4c9a-9fdd-ce844228c4e5",
                            TwoFactorEnabled = false,
                            UserName = "stanley@mail.com"
                        },
                        new
                        {
                            Id = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6c2125c-9a9b-4196-ba24-4fe4b79962f1",
                            Email = "clarissa@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLARISSA@MAIL.COM",
                            NormalizedUserName = "CLARISSA@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI1yUgqTyx7hlO05U264k9M19BxKBDJ3aSXo1pzZAIFkROTgwzPHTgARPOnIEnquUw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bf33da58-5a4d-4f1d-8537-612cca952ea8",
                            TwoFactorEnabled = false,
                            UserName = "clarissa@mail.com"
                        },
                        new
                        {
                            Id = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55ad33ff-284d-4f89-ac2e-59548e199d38",
                            Email = "gaby@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GABY@MAIL.COM",
                            NormalizedUserName = "GABY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEhFt+fSBOFJxFRMMokpOy9lxHgMamr19mlNL1pPi8rJce9qsgQEnH6GvXl0iiVU6g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "200be417-c8be-4482-819e-b479c39ce15c",
                            TwoFactorEnabled = false,
                            UserName = "gaby@mail.com"
                        },
                        new
                        {
                            Id = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b23b034d-8691-4708-8ceb-dae31b2e5ffc",
                            Email = "cleo@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLEO@MAIL.COM",
                            NormalizedUserName = "CLEO@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDfZ0Y9H7b9yytx5PBrzwNyKlEwVecuampSYcyPqMg///mHqfEGlrVNP1VDcSQMdlw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "67b4cd4d-3fbc-4eab-b35b-561bab11ed7d",
                            TwoFactorEnabled = false,
                            UserName = "cleo@mail.com"
                        },
                        new
                        {
                            Id = "64792414-6240-4f4a-a06b-e519464f4fc0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6301c47f-f942-426b-b152-2b4f8fa75555",
                            Email = "vincent@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VINCENT@MAIL.COM",
                            NormalizedUserName = "VINCENT@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA6AmLdvJapaOpBn7ar7Y5qXCxX9BUBJ8UZUFFe52c15JOXS69HSr55j5CR2Xm8pDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d82a7964-d4a0-41d4-877b-1519f3e750de",
                            TwoFactorEnabled = false,
                            UserName = "vincent@mail.com"
                        },
                        new
                        {
                            Id = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80792805-8366-4966-9fca-4a4cc2e96fd9",
                            Email = "jepe@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JEPE@MAIL.COM",
                            NormalizedUserName = "JEPE@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPNacUHl4tdnazfdCBU6w5yzZZW8YbbVrx/gTWoHVe9OBjZzpJCVCTRc78/olkyyxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2db92e60-cb14-4b3c-ad59-ff4e2c3bccfb",
                            TwoFactorEnabled = false,
                            UserName = "jepe@mail.com"
                        },
                        new
                        {
                            Id = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6ce0b830-d382-4078-b00e-ba72048c490b",
                            Email = "onel@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ONEL@MAIL.COM",
                            NormalizedUserName = "ONEL@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFivPreO7UfCOjdDC9TkaOfrd8E4fVxSKL5xd/1zuD9OD3kwDOX2VmRUjorCiT09Tw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fda842e8-50dc-4190-9e01-f23f185afd65",
                            TwoFactorEnabled = false,
                            UserName = "onel@mail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "af3246f8-2bc5-404b-8212-3a5005c98790",
                            RoleId = "admin"
                        },
                        new
                        {
                            UserId = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "64792414-6240-4f4a-a06b-e519464f4fc0",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                            RoleId = "participant"
                        },
                        new
                        {
                            UserId = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                            RoleId = "participant"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.PossibleAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("PossibleAnswers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "true",
                            IsCorrect = true,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Answer = "false",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Answer = "Pancasila",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Answer = "Trisila",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Answer = "UUD 1945",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Answer = "Soekarno",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Answer = "Soeharto",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            Answer = "BJ Habibie",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Answer = "Abdurrahman Wahid",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Answer = "Megawati Soekarnoputri",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Answer = "Susilo Bambang Yudhoyono",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            Answer = "Joko Widodo",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            Answer = "Dasar Negara",
                            IsCorrect = true,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            Answer = "Pajangan",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            Answer = "Tidak berperan sebagai apa - apa",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            Answer = "true",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 17,
                            Answer = "false",
                            IsCorrect = true,
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasCorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasCorrectAnswer = true,
                            QuestionText = "Soekarno adalah presiden pertama Indonesia",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 2,
                            HasCorrectAnswer = true,
                            QuestionText = "Apa ideologi yang dianut oleh Indonesia ?",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            HasCorrectAnswer = true,
                            QuestionText = "Siapa president ketiga Republik Indonesia ?",
                            QuestionTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            HasCorrectAnswer = true,
                            QuestionText = "Dalam kehidupan bernegara Pancasila berperan sebagai ?",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            HasCorrectAnswer = true,
                            QuestionText = "Hari lahir pancasila diperingati setiap tanggal 2 Juni",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            HasCorrectAnswer = false,
                            QuestionText = "Sebutkan alinea kesatu pembukaan UUD 1945",
                            QuestionTypeId = 4
                        },
                        new
                        {
                            Id = 7,
                            HasCorrectAnswer = false,
                            QuestionText = "Tuliskan rumusan awal Pancasila berdasarkan Piagam Jakarta di sebuah kertas. Kemudian foto, lalu upload melalui form dibawah.",
                            QuestionTypeId = 5
                        });
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Multiple choice"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Boolean"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Select from list"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Essay"
                        },
                        new
                        {
                            Id = 5,
                            Type = "File Upload"
                        });
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TakenOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "",
                            UserId = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            endDate = new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 10, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Status = "",
                            UserId = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                            endDate = new DateTime(2021, 6, 14, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 14, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            Status = "",
                            UserId = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                            endDate = new DateTime(2021, 6, 11, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 11, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            Status = "",
                            UserId = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                            endDate = new DateTime(2021, 6, 10, 19, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 10, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            Status = "",
                            UserId = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                            endDate = new DateTime(2021, 6, 9, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 9, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 6,
                            Status = "",
                            UserId = "64792414-6240-4f4a-a06b-e519464f4fc0",
                            endDate = new DateTime(2021, 6, 8, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 8, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 7,
                            Status = "",
                            UserId = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                            endDate = new DateTime(2021, 6, 15, 18, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 15, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 8,
                            Status = "",
                            UserId = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                            endDate = new DateTime(2021, 6, 10, 21, 0, 0, 0, DateTimeKind.Local),
                            startDate = new DateTime(2021, 6, 10, 18, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.UserAnswer", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCorrect")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.PossibleAnswer", b =>
                {
                    b.HasOne("RDT_WEB_LL.Models.Question", "Question")
                        .WithMany("PossibleAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.Question", b =>
                {
                    b.HasOne("RDT_WEB_LL.Models.QuestionType", "QuestionType")
                        .WithMany()
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.Schedule", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.UserAnswer", b =>
                {
                    b.HasOne("RDT_WEB_LL.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RDT_WEB_LL.Models.Question", b =>
                {
                    b.Navigation("PossibleAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
