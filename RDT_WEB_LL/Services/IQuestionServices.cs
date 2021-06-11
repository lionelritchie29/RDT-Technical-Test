using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public interface IQuestionServices
    {
        public Task<List<Question>> GetAll();
        public Task<Question> Get(int questionid);
        public Task<int> Add(Question newQuestion);
        public Task<int> Update(Question question);
        public Task<int> AddAnswers(List<PossibleAnswer> answers);
        public Task<int> UpdateAnswers(List<PossibleAnswer> answers, int questionId);
        public Task<int> SaveUserAnswers(List<UserAnswer> answers);
        public Task<List<UserAnswer>> GetUserAnswers(string userId);
        public Task<int> Delete(Question question);
        public Task<int> UpdateAnswerCorrectStatus(UserAnswer answer, bool isCorrect);
        public Task<List<UserAnswer>> GetAnswersByUserId(string userId);
    }
}
