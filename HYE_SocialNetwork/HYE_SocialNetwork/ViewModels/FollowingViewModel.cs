using HYE_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<Following> Followings { get; set; }
        public IEnumerable<ApplicationUser> Followees { get; set; }
        public IEnumerable<ApplicationUser> Followers { get; set; }
        //public DateTime DateTime { get; set; }
        public bool ShowActions { get; set; }
    }
}