using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public class ChatModels : MessageModels
    {
        public int MyProperty { get; set; }

        [ForeignKey("Recipient")]
        public string RecipientId { get; set; }

        public virtual ApplicationUser Recipient { get; set; }
    }
}