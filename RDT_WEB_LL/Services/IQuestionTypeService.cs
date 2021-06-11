using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    interface IQuestionTypeService
    {
        public Task<List<QuestionType>> GetAll();
    }
}
