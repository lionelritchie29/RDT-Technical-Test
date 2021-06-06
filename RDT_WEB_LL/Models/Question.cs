using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; }
        public string QuestionText { get; set; }
        public bool HasCorrectAnswer { get; set; }
    }
}
