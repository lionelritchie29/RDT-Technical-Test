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
                            ConcurrencyStamp = "7a957f0f-bc21-4d7f-b36f-2326a05a5adb",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "participant",
                            ConcurrencyStamp = "424f98fe-cadd-45b9-b33e-504fa410e915",
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
                            ConcurrencyStamp = "b8cb9336-6cfc-4e33-a8ac-73e590960fc3",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC8kfqMt1vSV/kJk4CmY0qHmSWfgfTTnclouOtzFAUlXATTviBPLYmBfryFngjePlg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a9a1b902-5d97-44fe-a290-0e20d6bd0bae",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "860d4c40-975c-4259-ae9e-05ca2e9d645f",
                            Email = "brandon@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BRANDON@MAIL.COM",
                            NormalizedUserName = "BRANDON@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENyYjug/upo+a53b/AtSz4VMjvVMQjelmnrdevbRYlM3jW9IOLKEKmAJiemFsRWlbA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "80f859be-edec-4984-ab21-498ea87a8751",
                            TwoFactorEnabled = false,
                            UserName = "brandon@mail.com"
                        },
                        new
                        {
                            Id = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ead4a404-5f80-4da9-bd93-bfe5afe18397",
                            Email = "stanley@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STANLEY@MAIL.COM",
                            NormalizedUserName = "STANLEY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEKstYt7QutAzk/fJlMKgInf7kA7Yd7EqpDKzw129rIzesGc+EAU0f5gt4HBhhgFqQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aa0ab923-fac1-4193-8c20-352c7e137f8e",
                            TwoFactorEnabled = false,
                            UserName = "stanley@mail.com"
                        },
                        new
                        {
                            Id = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc3c8694-4612-4777-aa81-d573b75a2f0b",
                            Email = "clarissa@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLARISSA@MAIL.COM",
                            NormalizedUserName = "CLARISSA@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECM0+zxXNrZSxuCgaTdWIJMONRbDTV7chkKJPeNe8lR6+IBROs7NO5fOj/mh49TC8A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "322cabc1-2914-4194-89e4-f249d394c27b",
                            TwoFactorEnabled = false,
                            UserName = "clarissa@mail.com"
                        },
                        new
                        {
                            Id = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "495acbec-bb66-4625-832e-d148d36a0b11",
                            Email = "gaby@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GABY@MAIL.COM",
                            NormalizedUserName = "GABY@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJuqsFarkFEQ5mSGkbjBkwoI7LK/fxvjMIQCao02fzccKchKwnjY7pywhC5pu96fHw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06d5200a-3629-4d68-8fb8-7bd876ceaf17",
                            TwoFactorEnabled = false,
                            UserName = "gaby@mail.com"
                        },
                        new
                        {
                            Id = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37f82a51-a573-4dec-be1f-772a5995fa3c",
                            Email = "cleo@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLEO@MAIL.COM",
                            NormalizedUserName = "CLEO@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJiflqnYFuGhc9JWIdg7IB/EGYHrHWJhDzFpKrbrCm6gjI06Fe/XHGbxa6vp2BV/vQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2c9104eb-1458-4dae-a1e2-98a0c76690aa",
                            TwoFactorEnabled = false,
                            UserName = "cleo@mail.com"
                        },
                        new
                        {
                            Id = "64792414-6240-4f4a-a06b-e519464f4fc0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f6bbc0d2-c7c5-4397-a19b-dfab64e437c9",
                            Email = "vincent@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VINCENT@MAIL.COM",
                            NormalizedUserName = "VINCENT@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELU0h391PGXVSoNz9ypooni++ayCm6oEc7IVuU1/PKtOqbew3CsLWT7KOylhudPh+g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "972bb125-6654-4bb6-9b3e-bb0cc07050ee",
                            TwoFactorEnabled = false,
                            UserName = "vincent@mail.com"
                        },
                        new
                        {
                            Id = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cc796f5-ec2e-4ce1-8fc3-5ed9be68c2d6",
                            Email = "jepe@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JEPE@MAIL.COM",
                            NormalizedUserName = "JEPE@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEKtE0zUwUZpoisB4k8/iaxB8LCRCNHRW8vdbi1k6KB41Iq7fIaWB1gjGC5fxFiEYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a565c8f0-a93e-4893-bece-3c85af1f388c",
                            TwoFactorEnabled = false,
                            UserName = "jepe@mail.com"
                        },
                        new
                        {
                            Id = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6e4f70e5-2d7c-43a6-a181-a680df6751c1",
                            Email = "onel@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ONEL@MAIL.COM",
                            NormalizedUserName = "ONEL@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN6oywZ4D9Yda6sZ4/iR7YQKuRcyVQq7m0/Qe6ELSHPuIdASPe8KmeTazraEuKVOIg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e46964f-a616-47ce-88dd-0c60fa2231ec",
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
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
