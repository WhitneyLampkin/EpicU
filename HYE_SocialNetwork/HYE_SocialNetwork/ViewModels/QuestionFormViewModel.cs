using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class QuestionFormViewModel
    {
        [Required]
        public string Question { get; set; }
    }
}