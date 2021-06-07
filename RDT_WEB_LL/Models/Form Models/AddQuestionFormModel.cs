using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models.Form_Models
{
    public class AddQuestionFormModel
    {
        [Required(ErrorMessage = "You must fill the question text")]
        public string QuestionText { get; set; }

        [Required(ErrorMessage = "You must select a question type")]
        public string QuestionTypeId { get; set; }
        public bool HasCorrectAnswer { get; set; }

        //[ValidateComplexType]
        public List<PossibleAnswerFormModel> PossibleAnswers { get; set; }

        public AddQuestionFormModel()
        {
            this.PossibleAnswers = new List<PossibleAnswerFormModel>();
        }
    }
}
