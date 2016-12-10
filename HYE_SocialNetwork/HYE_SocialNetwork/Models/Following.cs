﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.Models
{
    public class Following
    {

        public ApplicationUser Follwer { get; set; }
        public ApplicationUser Followee { get; set; }
        public int FriendshipId { get; set; }
        public DateTime DateTime { get; set; }
        public bool Friends { get; set; }

        [Key]
        [Column(Order = 1)]
        public int FollowerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FolloweeId { get; set; }
    }
}