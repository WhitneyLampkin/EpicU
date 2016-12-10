using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HYE_SocialNetwork.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<HYEQuestion> HYEQuestions { get; set; }
        public DbSet<HYEAnswer> HYEAnswers { get; set; }
        public DbSet<Friendship> Friendships { get; set; }

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
            modelBuilder.Entity<HYEAnswer>()
                .HasRequired(a => a.HYEQuestion)
                .WithMany()
                .WillCascadeOnDelete(false);

            //Relationship between the Requester and Requestee for the Friendship model
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Requesters)
                .WithRequired(r => r.Requestee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Requestees)
                .WithRequired(r => r.Requester)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
        
        
    }
}