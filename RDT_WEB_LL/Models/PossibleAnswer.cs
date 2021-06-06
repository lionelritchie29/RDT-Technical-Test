using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models
{
    public class PossibleAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
