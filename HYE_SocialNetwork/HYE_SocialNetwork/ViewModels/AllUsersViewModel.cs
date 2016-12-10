using HYE_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class AllUsersViewModel
    {
        public IEnumerable<ApplicationUser> HYEUsers { get; set; }

        public string Displayame { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}