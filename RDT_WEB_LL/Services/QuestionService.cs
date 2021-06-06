using Microsoft.EntityFrameworkCore;
using RDT_WEB_LL.Data;
using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public class QuestionService : IQuestionServices
    {
        private readonly ApplicationDbContext _context;

        public QuestionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAll()
        {
            List<Question> questions = await _context.Questions.Include(q => q.QuestionType).ToListAsync();
            foreach (var q in questions)
            {
                q.PossibleAnswers = _context.PossibleAnswers.Where(ans => ans.QuestionId == q.Id).ToList();
            }
            return questions;
        }
    }
}
