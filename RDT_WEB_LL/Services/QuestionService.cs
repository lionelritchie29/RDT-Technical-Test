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

        public int Add(Question newQuestion)
        {
            _context.Questions.Add(newQuestion);
            _context.SaveChanges();
            return newQuestion.Id;
        }

        public int AddAnswers(List<PossibleAnswer> answers)
        {
            _context.PossibleAnswers.AddRange(answers.ToArray());
            int status = _context.SaveChanges();
            return status;
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

        public int Delete(Question question)
        {
            if (question.HasCorrectAnswer)
            {
                DeleteAnswers(question.Id);
            }
            _context.Questions.Remove(question);
            return _context.SaveChanges();
        }
        
        private void DeleteAnswers(int questionId)
        {
            List<PossibleAnswer> answers = _context.PossibleAnswers.Where(ans => ans.QuestionId == questionId).ToList();
            if (answers.Count() > 0)
            {
                _context.PossibleAnswers.RemoveRange(answers);
                _context.SaveChanges();
            }
        }
    }
}
