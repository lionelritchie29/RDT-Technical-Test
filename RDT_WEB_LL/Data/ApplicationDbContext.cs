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

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser { 
                    Id = "af3246f8-2bc5-404b-8212-3a5005c98790",
                    UserName = "Admin",
                    Email = "admin@mail.com",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },

                new IdentityUser
                {
                    Id = "dc954b45-44ef-4404-b8d6-d502ec9de9ec",
                    UserName = "Brandon Julio",
                    Email = "brandon@mail.com",
                    PasswordHash = hasher.HashPassword(null, "Brandon123!"),
                    SecurityStamp = Guid.NewGuid().ToString()
                });
        }

        private void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "admin", Name = "Admin"},
               new IdentityRole { Id = "participant", Name = "Participant"}
               );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "admin", UserId = "af3246f8-2bc5-404b-8212-3a5005c98790" },
                new IdentityUserRole<string> { RoleId = "participant", UserId = "dc954b45-44ef-4404-b8d6-d502ec9de9ec" }
                );
        }
    }
}
