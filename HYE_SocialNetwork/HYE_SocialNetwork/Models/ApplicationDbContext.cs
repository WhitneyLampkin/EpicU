using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HYE_SocialNetwork.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<HYEQuestion> HYEQuestions { get; set; }
        public DbSet<HYEAnswer> HYEAnswers { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}