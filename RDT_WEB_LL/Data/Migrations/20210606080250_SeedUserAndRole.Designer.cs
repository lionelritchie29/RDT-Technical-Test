﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RDT_WEB_LL.Data;

namespace RDT_WEB_LL.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210606080250_SeedUserAndRole")]
    partial class SeedUserAndRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "b72b20dc-24d4-4b0e-9f84-38fa5120633a",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "participant",
                            ConcurrencyStamp = "a3166b86-a3de-40b0-87bf-d2cb3dd30746",
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
                            ConcurrencyStamp = "ff401096-8d27-44e4-9fb7-2ce9304651fc",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEL3XGVeMIlgdh1r/Z8gq/5J0OZbTFMbxMySs3fI9Qw/GxgqrrgSiV0vQ01g44vDHRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "758b567f-1ce9-4d57-87eb-d60d72fce6ce",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c055af86-0a1b-411c-8a0f-cd58839b2e13",
                            Email = "brandon@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEO80JUwNVeudo2IHsmoM4JfngY6YTxhjjyWmNWqEoyajPMxGIWxG1DAeyZqsP5qw4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d20db892-46d3-4a88-9212-befb7bdd44ae",
                            TwoFactorEnabled = false,
                            UserName = "Brandon Julio"
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

            modelBuilder.Entity("RDT_WEB_LL.Models.UserAnswer", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
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
                        .WithMany()
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
#pragma warning restore 612, 618
        }
    }
}
