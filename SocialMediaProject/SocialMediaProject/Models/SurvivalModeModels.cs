using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public class SurvivalMode : ScenarioModels
    {
        public DateTime Timer { get; set; }
        public DateTime FastestTime { get; set; }

        [ForeignKey("FastestUser")]
        public string FastestUserId { get; set; }

        public virtual ApplicationUser FastestUser { get; set; }
    }
}