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
                            ConcurrencyStamp = "812673be-38fe-48c5-9936-7696ba8086c1",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "participant",
                            ConcurrencyStamp = "271ab109-588f-4b34-b757-71e72198b3a8",
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
                            ConcurrencyStamp = "776a4362-f185-45a3-9df2-8ec1b6b022cb",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMa30i7b8M9KZANxCqxExlRM5qJFvPleb5bEg3Wp8sL+Ravm+yqOM56xXczJmh1Pyg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7483b490-7d59-49a1-9ddb-d454de96aa5a",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27fd22d2-fe2a-47d2-bd90-d64cb8d1729a",
                            Email = "brandon@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BRANDON@MAIL.COM",
                            NormalizedUserName = "BRANDON@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAIxxMPWMn3dozVH6m+E3P1kZsCuuV1M33dy+aIs3azq5ZTlz+tD1edNdoZocJFlZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d7a0564d-6767-4783-a7ee-1b7633d3b053",
                            TwoFactorEnabled = false,
                            UserName = "brandon@mail.com"
                        },
                        new
                        {
                            Id = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "528ad953-5962-41bb-a83d-46744c8462df",
                            Email = "stanley@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STANLEY@MAIL.COM",
                            NormalizedUserName = "STANLEY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENlE56QRkAVPs30e2Z0YCNWtqqsNCDAPkVyLGvo2X4hceSaAVD326/wL6KNXzhWLXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b3284933-4331-4e06-a100-927701fc881c",
                            TwoFactorEnabled = false,
                            UserName = "stanley@mail.com"
                        },
                        new
                        {
                            Id = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7f097446-f7b1-43bc-97ad-c3e09deae1a1",
                            Email = "clarissa@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLARISSA@MAIL.COM",
                            NormalizedUserName = "CLARISSA@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPxXJHmU206mrDBHbqnFH8y0w//Bgr1BrIt6fj9dFS2ynCImqtD1Bwmf4nVdtrLuGg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4f97bed1-eae9-4801-b434-1d8d419bc64b",
                            TwoFactorEnabled = false,
                            UserName = "clarissa@mail.com"
                        },
                        new
                        {
                            Id = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6ba1f37f-d9b9-442c-8958-a3d457664d0a",
                            Email = "gaby@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GABY@MAIL.COM",
                            NormalizedUserName = "GABY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK9dMuPR4B48T3Q9OD3kYS6LhwWK22tIVtCKE1owHkJXA99f1DEeE13027dwsKeMyQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a778a41b-f5ea-458e-ac1d-b61c64552b11",
                            TwoFactorEnabled = false,
                            UserName = "gaby@mail.com"
                        },
                        new
                        {
                            Id = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f7cc408b-560a-4b51-8486-ecea42f1064d",
                            Email = "cleo@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLEO@MAIL.COM",
                            NormalizedUserName = "CLEO@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIMX8E4GL3k2Cg84ivn3Kq5LNuZJw5mn85X3P9evhfvJfPUT4g3dk0wigil5SqVURA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f6e22764-3242-403d-adf2-973a8b9250d9",
                            TwoFactorEnabled = false,
                            UserName = "cleo@mail.com"
                        },
                        new
                        {
                            Id = "64792414-6240-4f4a-a06b-e519464f4fc0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "47e0ffba-f3c5-4ca1-9515-84251b977c87",
                            Email = "vincent@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VINCENT@MAIL.COM",
                            NormalizedUserName = "VINCENT@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELEEx0TC+KhuJn+Owh3z+UBrWQMxIfFG0FfwvOAEHPfKpwbCbdqsqMgwWA5VcJToBA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "350c7ed9-4996-43bd-86ec-dadc7b5ae1cd",
                            TwoFactorEnabled = false,
                            UserName = "vincent@mail.com"
                        },
                        new
                        {
                            Id = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc56a5ce-9a68-490e-94b0-3e29415c3ce1",
                            Email = "jepe@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JEPE@MAIL.COM",
                            NormalizedUserName = "JEPE@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELQqGJViZ+77CB5VjEB98JmMF/Dp8jWfxNaotQqRl7YlZsRb1/QVd4szr3034t2h2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9eca7138-a452-4b91-a8dd-d982d7ddd13d",
                            TwoFactorEnabled = false,
                            UserName = "jepe@mail.com"
                        },
                        new
                        {
                            Id = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af700a2c-899e-4023-a98b-54cf1471fe51",
                            Email = "onel@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ONEL@MAIL.COM",
                            NormalizedUserName = "ONEL@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENcujXENGwSDOVMcwpz2EH96GCIUoNrZW9Bn8bTOQNKk6GRPJqJt5PFHOimN9I/lvA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fb9e12a-787f-4901-8a83-9de6a6f70ece",
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
