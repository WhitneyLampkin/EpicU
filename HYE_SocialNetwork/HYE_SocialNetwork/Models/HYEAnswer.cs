using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HYE_SocialNetwork.Models
{
    public class HYEAnswer
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser RespondingUser { get; set; }

        public DateTime DateTime { get; set; }
        
        [Required]
        public bool UserResponse { get; set; }

        public int? Exposed { get; set; }

        [Required]
        [ForeignKey("QuestionId")]
        public int QId { get; set; }

        public virtual HYEQuestion QuestionId { get; set; }
    }
}