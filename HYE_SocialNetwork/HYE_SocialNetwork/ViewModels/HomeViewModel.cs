using HYE_SocialNetwork.Models;
using System.Collections.Generic;

namespace HYE_SocialNetwork.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<HYEQuestion> NewQuestions { get; set; }
        public bool ShowActions { get; set; }
    }
}