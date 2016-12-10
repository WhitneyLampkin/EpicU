using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HYE_SocialNetwork.Models
{
    public class Friendship
    {
        public int Id { get; set; }

        //Composite Primary Key using two Ids
        [Key]
        [Column(Order = 1)]
        public string ResquesterId { get; set; }

        [Key]
        [Column(Order  = 2)]
        public string RequesteeId { get; set; }

        public ApplicationUser Requester { get; set; }
        public ApplicationUser Requestee { get; set; }
}
}