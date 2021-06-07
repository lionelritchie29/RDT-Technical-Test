using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models.Form_Models
{
    public class AddQuestionFormModel
    {
        [Required]
        public string QuestionText { get; set; }

        public string QuestionType { get; set; }


        public List<PossibleAnswerFormModel> PossibleAnswers { get; set; }

        public AddQuestionFormModel()
        {
            this.PossibleAnswers = new List<PossibleAnswerFormModel>();
        }
    }
}
