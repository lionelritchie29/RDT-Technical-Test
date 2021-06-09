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

        public int SaveUserAnswers(List<UserAnswer> answers)
        {
            _context.UserAnswers.AddRange(answers);
            int status = _context.SaveChanges();
            return status;
        }

        public List<Question> GetAll()
        {
            List<Question> questions = _context.Questions.Include(q => q.QuestionType).ToList();
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

        public List<UserAnswer> GetUserAnswers(string userId)
        {
            List<UserAnswer> answers = _context.UserAnswers.Include(ans => ans.Question).Where(ans => ans.UserId == userId).ToList();
            return answers;
        }

        public int UpdateAnswerCorrectStatus(UserAnswer answer, bool isCorrect)
        {
            UserAnswer ans = answer;
            ans.IsCorrect = isCorrect;
            _context.UserAnswers.Update(ans);

            int status = _context.SaveChanges();
            return status;
        }
    }
}
