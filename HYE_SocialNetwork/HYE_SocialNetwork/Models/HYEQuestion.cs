using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HYE_SocialNetwork.Models
{
    public class HYEQuestion
    {
        public int Id { get; set; }
        
        public ApplicationUser Inquirer { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public string Question { get; set; }

        public int? Liked { get; set; }
        
        public string InquirerId { get; set; }
    }
}