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
        private readonly IAuthService _authService;

        public QuestionService(ApplicationDbContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<Question> Get(int questionid)
        {
            return await _context.Questions.Include(q => q.PossibleAnswers).Where(q => q.Id == questionid).FirstOrDefaultAsync();
        }

        public async Task<int> Add(Question newQuestion)
        {
            _context.Questions.Add(newQuestion);
            await _context.SaveChangesAsync();
            return newQuestion.Id;
        }

        public async Task<int> Update(Question question)
        {
            _context.Questions.Update(question);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateAnswers(List<PossibleAnswer> answers, int questionId)
        {
            var oldAnswers = await _context.PossibleAnswers.Where(ans => ans.QuestionId == questionId).ToListAsync();
            _context.PossibleAnswers.RemoveRange(oldAnswers);
            _context.PossibleAnswers.AddRange(answers);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAnswers(List<PossibleAnswer> answers)
        {
            _context.PossibleAnswers.AddRange(answers.ToArray());
            return await _context.SaveChangesAsync();
        }

        public async Task<int> SaveUserAnswers(List<UserAnswer> answers)
        {
            _context.UserAnswers.AddRange(answers);
            var schedule = await _context.Schedules.Where(s => s.UserId == _authService.GetCurrentUserId()).FirstOrDefaultAsync();
            schedule.TakenOn = DateTime.Now;

            int status = await _context.SaveChangesAsync();
            return status;
        }

        public async Task<List<Question>> GetAll()
        {
            List<Question> questions = await _context.Questions.Include(q => q.QuestionType).ToListAsync();
            foreach (var q in questions)
            {
                q.PossibleAnswers = await _context.PossibleAnswers.Where(ans => ans.QuestionId == q.Id).ToListAsync();
            }
            return questions;
        }

        public async Task<int> Delete(Question question)
        {
            if (question.HasCorrectAnswer)
            {
                await DeleteAnswers(question.Id);
            }
            _context.Questions.Remove(question);
            return await _context.SaveChangesAsync();
        }
        
        private async Task DeleteAnswers(int questionId)
        {
            List<PossibleAnswer> answers = await _context.PossibleAnswers.Where(ans => ans.QuestionId == questionId).ToListAsync();
            if (answers.Count() > 0)
            {
                _context.PossibleAnswers.RemoveRange(answers);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<UserAnswer>> GetUserAnswers(string userId)
        {
            var answers = await _context.UserAnswers.Include(ans => ans.Question).Where(ans => ans.UserId == userId).ToListAsync();
            return answers;
        }

        public async Task<int> UpdateAnswerCorrectStatus(UserAnswer answer, bool isCorrect)
        {
            UserAnswer ans = answer;
            ans.IsCorrect = isCorrect;
            _context.UserAnswers.Update(ans);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<UserAnswer>> GetAnswersByUserId(string userId)
        {
            return await _context.UserAnswers.Where(ans => ans.UserId == userId).ToListAsync();
        }
    }
}
