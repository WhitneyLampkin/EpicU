using HYE_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class ProfileViewModel
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public List<HYEQuestion> MyQuestions { get; set; }
        public List<HYEAnswer> MyAnswers { get; set; }
        public List<ApplicationUser> MyFollowees { get; set; }
        public List<ApplicationUser> MyFollowers { get; set; }
        public bool ShowActions { get; set; }
    }
}