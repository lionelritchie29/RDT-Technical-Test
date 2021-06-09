using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    interface IQuestionServices
    {
        public List<Question> GetAll();
        public int Add(Question newQuestion);
        public int AddAnswers(List<PossibleAnswer> answers);
        public int SaveUserAnswers(List<UserAnswer> answers);
        public List<UserAnswer> GetUserAnswers(string userId);
        public int Delete(Question question);
        public int UpdateAnswerCorrectStatus(UserAnswer answer, bool isCorrect);
    }
}
