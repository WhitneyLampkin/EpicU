using HYE_SocialNetwork.Models;
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
        public int Id { get; set; }
        public bool ShowActions { get; set; }
        public IEnumerable<HYEQuestion> MyQuestions { get; set; }
    }
}