using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SocialMediaProject.Models
{
    public enum Difficulty { Easy, Intermediate, Advanced }

    public class ScenarioModels
    {
        [Key]
        public int Id { get; set; }

        public Difficulty? Difficulty { get; set; }
        public string Backstory { get; set; }
        public DateTime Date { get; set; }
        public string WrongAnsA { get; set; }
        public string WrongAnsB { get; set; }
        public string CorrectAns { get; set; }
        public string SourceLink { get; set; }
        public byte[] Image { get; set; }
        public string BackupImage { get; set; }
        public string Result { get; set; }
        public int TotalAttemps { get; set; }
        public int TotalWrongAns { get; set; }
        public int TotalCorrectAns { get; set; }
        public bool Favorite { get; set; }
        public int TotalFavors { get; set; }
        public string Goal { get; set; }
        public List<ApplicationUser> FavoredBy { get; set; }

    }
}