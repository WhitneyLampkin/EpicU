using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public class CommentModels : MessageModels
    {
        public bool LikeBtn { get; set; }
        public int TotalLikes { get; set; }
        public List<ApplicationUser> LikedBy { get; set; }
    }
}