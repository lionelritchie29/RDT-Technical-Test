using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDT_WEB_LL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserAnswer>().HasKey(userAns => new { userAns.UserId, userAns.QuestionId });

            //Seeding
            SeedQuestionType(modelBuilder);
            SeedQuestions(modelBuilder);
            SeedPossibleAnswers(modelBuilder);
            SeedUser(modelBuilder);
            SeedRole(modelBuilder);
            SeedSchedule(modelBuilder);
        }

        private void SeedQuestionType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionType>().HasData(
                new QuestionType { Id = 1, Type = "Multiple choice" },
                new QuestionType { Id = 2, Type = "Boolean" },
                new QuestionType { Id = 3, Type = "Select from list" },
                new QuestionType { Id = 4, Type = "Essay" },
                new QuestionType { Id = 5, Type = "File Upload" }
                );
        }

        private void SeedQuestions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question { Id = 1, QuestionTypeId = 2, HasCorrectAnswer = true, QuestionText = "Soekarno adalah presiden pertama Indonesia" },
                new Question { Id = 2, QuestionTypeId = 1, HasCorrectAnswer = true, QuestionText = "Apa ideologi yang dianut oleh Indonesia ?" },
                new Question { Id = 3, QuestionTypeId = 3, HasCorrectAnswer = true, QuestionText = "Siapa president ketiga Republik Indonesia ?" },
                new Question { Id = 4, QuestionTypeId = 1, HasCorrectAnswer = true, QuestionText = "Dalam kehidupan bernegara Pancasila berperan sebagai ?" },
                new Question { Id = 5, QuestionTypeId = 2, HasCorrectAnswer = true, QuestionText = "Hari lahir pancasila diperingati setiap tanggal 2 Juni" },
                new Question { Id = 6, QuestionTypeId = 4, HasCorrectAnswer = false, QuestionText = "Sebutkan alinea kesatu pembukaan UUD 1945" },
                new Question { Id = 7, QuestionTypeId = 5, HasCorrectAnswer = false, QuestionText = "Tuliskan rumusan awal Pancasila berdasarkan Piagam Jakarta di sebuah kertas. Kemudian foto, lalu upload melalui form dibawah." }
                );
        }

        private void SeedPossibleAnswers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PossibleAnswer>().HasData(
                new PossibleAnswer { Id = 1, QuestionId = 1, Answer = "true", IsCorrect = true},
                new PossibleAnswer { Id = 2, QuestionId = 1, Answer = "false", IsCorrect = false},

                new PossibleAnswer { Id = 3, QuestionId = 2, Answer = "Pancasila", IsCorrect = true},
                new PossibleAnswer { Id = 4, QuestionId = 2, Answer = "Trisila", IsCorrect = false},
                new PossibleAnswer { Id = 5, QuestionId = 2, Answer = "UUD 1945", IsCorrect = false},

                new PossibleAnswer { Id = 6, QuestionId = 3, Answer = "Soekarno", IsCorrect = false},
                new PossibleAnswer { Id = 7, QuestionId = 3, Answer = "Soeharto", IsCorrect = false},
                new PossibleAnswer { Id = 8, QuestionId = 3, Answer = "BJ Habibie", IsCorrect = true},
                new PossibleAnswer { Id = 9, QuestionId = 3, Answer = "Abdurrahman Wahid", IsCorrect = false},
                new PossibleAnswer { Id = 10, QuestionId = 3, Answer = "Megawati Soekarnoputri", IsCorrect = false},
                new PossibleAnswer { Id = 11, QuestionId = 3, Answer = "Susilo Bambang Yudhoyono", IsCorrect = false},
                new PossibleAnswer { Id = 12, QuestionId = 3, Answer = "Joko Widodo", IsCorrect = false},

                new PossibleAnswer { Id = 13, QuestionId = 4, Answer = "Dasar Negara", IsCorrect = true},
                new PossibleAnswer { Id = 14, QuestionId = 4, Answer = "Pajangan", IsCorrect = false},
                new PossibleAnswer { Id = 15, QuestionId = 4, Answer = "Tidak berperan sebagai apa - apa", IsCorrect = false},

                new PossibleAnswer { Id = 16, QuestionId = 5, Answer = "true", IsCorrect = false},
                new PossibleAnswer { Id = 17, QuestionId = 5, Answer = "false", IsCorrect = true}
                );
        }

        private void SeedUser(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser
            {
                Id = "af3246f8-2bc5-404b-8212-3a5005c98790",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant1 = new IdentityUser
            {
                Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                UserName = "brandon@mail.com",
                NormalizedUserName = "BRANDON@MAIL.COM",
                Email = "brandon@mail.com",
                NormalizedEmail = "BRANDON@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant2 = new IdentityUser
            {
                Id = "7c17889b-010f-41b3-b8d6-3521a10b1915",
                UserName = "stanley@mail.com",
                NormalizedUserName = "STANLEY@MAIL.COM",
                Email = "stanley@mail.com",
                NormalizedEmail = "STANLEY@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant3 = new IdentityUser
            {
                Id = "ff2fd92b-7657-4855-a9b9-70977cd91b3e",
                UserName = "clarissa@mail.com",
                NormalizedUserName = "CLARISSA@MAIL.COM",
                Email = "clarissa@mail.com",
                NormalizedEmail = "CLARISSA@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant4 = new IdentityUser
            {
                Id = "c12807d5-b1cd-45f0-85ee-6a293e07989d",
                UserName = "gaby@mail.com",
                NormalizedUserName = "GABY@MAIL.COM",
                Email = "gaby@mail.com",
                NormalizedEmail = "GABY@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant5 = new IdentityUser
            {
                Id = "035c6e49-5ac7-4eb7-8e96-2fee62b29289",
                UserName = "cleo@mail.com",
                NormalizedUserName = "CLEO@MAIL.COM",
                Email = "cleo@mail.com",
                NormalizedEmail = "CLEO@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant6 = new IdentityUser
            {
                Id = "64792414-6240-4f4a-a06b-e519464f4fc0",
                UserName = "vincent@mail.com",
                NormalizedUserName = "VINCENT@MAIL.COM",
                Email = "vincent@mail.com",
                NormalizedEmail = "VINCENT@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant7 = new IdentityUser
            {
                Id = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005",
                UserName = "jepe@mail.com",
                NormalizedUserName = "JEPE@MAIL.COM",
                Email = "jepe@mail.com",
                NormalizedEmail = "JEPE@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var participant8 = new IdentityUser
            {
                Id = "b63985bb-0aad-4ba2-abec-2570974c04ed",
                UserName = "onel@mail.com",
                NormalizedUserName = "ONEL@MAIL.COM",
                Email = "onel@mail.com",
                NormalizedEmail = "ONEL@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");
            participant1.PasswordHash = hasher.HashPassword(participant1, "Bran123!");
            participant2.PasswordHash = hasher.HashPassword(participant2, "Stan123!");
            participant3.PasswordHash = hasher.HashPassword(participant3, "Clar123!");
            participant4.PasswordHash = hasher.HashPassword(participant4, "Gaby123!");
            participant5.PasswordHash = hasher.HashPassword(participant5, "Cleo123!");
            participant6.PasswordHash = hasher.HashPassword(participant6, "Vincent123!");
            participant7.PasswordHash = hasher.HashPassword(participant7, "Jepe123!");
            participant8.PasswordHash = hasher.HashPassword(participant8, "Onel123!");


            modelBuilder.Entity<IdentityUser>().HasData(admin, participant1, participant2, participant3, participant4, participant5, participant6, participant7, participant8);
        }

        private void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "admin", Name = "Admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = "participant", Name = "Participant", NormalizedName = "PARTICIPANT"}
               );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "admin", UserId = "af3246f8-2bc5-404b-8212-3a5005c98790" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "dc954b45-44ef-4404-b8d6-d502ec9de9ec" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "7c17889b-010f-41b3-b8d6-3521a10b1915" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "ff2fd92b-7657-4855-a9b9-70977cd91b3e" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "c12807d5-b1cd-45f0-85ee-6a293e07989d" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "035c6e49-5ac7-4eb7-8e96-2fee62b29289" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "64792414-6240-4f4a-a06b-e519464f4fc0" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "b63985bb-0aad-4ba2-abec-2570974c04ed" }
                );
        }

        private void SeedSchedule(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1, UserId = "dc954b45-44ef-4404-b8d6-d502ec9de9ec", startDate = DateTime.Now, endDate = DateTime.Now.AddHours(6), Status = "" },
                new Schedule { Id = 2, UserId = "7c17889b-010f-41b3-b8d6-3521a10b1915", startDate = DateTime.Now.AddDays(2), endDate = DateTime.Now.AddDays(2).AddHours(6), Status = "" },
                new Schedule { Id = 3, UserId = "ff2fd92b-7657-4855-a9b9-70977cd91b3e", startDate = DateTime.Now.AddHours(6), endDate = DateTime.Now.AddHours(12), Status = "" },
                new Schedule { Id = 4, UserId = "c12807d5-b1cd-45f0-85ee-6a293e07989d", startDate = new DateTime(2021, 06, 11, 15, 0, 0, DateTimeKind.Local), endDate = new DateTime(2021, 06, 11, 19, 0, 0, DateTimeKind.Local), Status = "" },
                new Schedule { Id = 5, UserId = "035c6e49-5ac7-4eb7-8e96-2fee62b29289", startDate = new DateTime(2021, 06, 10, 12, 0, 0, DateTimeKind.Local), endDate = new DateTime(2021, 06, 10, 18, 0, 0, DateTimeKind.Local), Status = "" },
                new Schedule { Id = 6, UserId = "64792414-6240-4f4a-a06b-e519464f4fc0", startDate = DateTime.Now.AddHours(12), endDate = DateTime.Now.AddHours(18), Status = "" },
                new Schedule { Id = 7, UserId = "0cc4ae1a-0d6a-48b4-bb03-d4eeb8000005", startDate = DateTime.Now.AddHours(1), endDate = DateTime.Now.AddHours(7), Status = "" },
                new Schedule { Id = 8, UserId = "b63985bb-0aad-4ba2-abec-2570974c04ed", startDate = DateTime.Now.AddDays(3), endDate = DateTime.Now.AddDays(3).AddHours(6), Status = "" }
                );
        }
    }
}
