using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models.Form_Models
{
    public class PossibleAnswerFormModel
    {
        [Required(ErrorMessage = "You must fill the possible answer")]
        public string Value { get; set; }
        public bool IsCorrect { get; set; } = false;

    }
}
