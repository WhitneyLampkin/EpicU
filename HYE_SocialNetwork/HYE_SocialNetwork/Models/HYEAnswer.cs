using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HYE_SocialNetwork.Models
{
    public class HYEAnswer
    {
        public HYEQuestion HYEQuestion { get; set; }
        public ApplicationUser Responder { get; set; }
        public DateTime DateTime { get; set; }
        public int? Exposed { get; set; }
        public bool Answer { get; set; }

        [Key]
        [Column(Order = 1)]
        public int HYEQuestionId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ResponderId { get; set; }
    }
}