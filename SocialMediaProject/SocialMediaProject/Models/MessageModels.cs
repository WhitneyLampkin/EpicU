using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public class MessageModels
    {
        [Key]
        public int MessageId { get; set; }

        public DateTime Sent { get; set; }
        public string MessageBody { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }

        public virtual ApplicationUser Sender { get; set;}
    }
}