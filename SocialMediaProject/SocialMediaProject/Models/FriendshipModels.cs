using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public enum FriendshipStatus { Friends, NotFriends, Pending, Blocked }

    public class FriendshipModels
    {
        [Key]
        public int FriendshipId { get; set; }
        
        public FriendshipStatus? FriendshipStatus  { get; set; }
        public bool CurrentUserOnline { get; set; }
        public bool RecipientOnline { get; set; }

        [ForeignKey("CurrentUser")]
        public string CurrentUserId { get; set; }

        [ForeignKey("Recipient")]
        public string RecipientId { get; set; }

        public virtual ApplicationUser CurrentUser { get; set; }
        public virtual ApplicationUser Recipient { get; set; }
    }
}