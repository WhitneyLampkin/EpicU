using HYE_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.ViewModels
{
    public class AskedViewModel
    {

        public IEnumerable<HYEQuestion> MyQuestions { get; set; }
        public bool ShowActions { get; set; }
    }
}