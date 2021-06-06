using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models
{
    public class UserAnswer
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
