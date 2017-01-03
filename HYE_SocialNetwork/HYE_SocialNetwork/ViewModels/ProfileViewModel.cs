using HYE_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class ProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public List<string> Questions { get; set; }
        public List<bool> Answers { get; set; }
    }
}