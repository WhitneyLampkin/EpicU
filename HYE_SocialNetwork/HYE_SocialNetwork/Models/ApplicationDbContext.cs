using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HYE_SocialNetwork.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<HYEQuestion> HYEQuestions { get; set; }
        public DbSet<HYEAnswer> HYEAnswers { get; set; }
        public DbSet<Following> Followings { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Turns off on cascade delete with fluent API
            modelBuilder.Entity<HYEAnswer>()
                .HasRequired(a => a.HYEQuestion)
                .WithMany()
                .WillCascadeOnDelete(false);

            //Relationship between the Requester and Requestee for the Friendship model
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followers)
                .WithRequired(f => f.Followee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followees)
                .WithRequired(f => f.Follower)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
        
        
    }
}