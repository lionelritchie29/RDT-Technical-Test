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
        }
    }
}
