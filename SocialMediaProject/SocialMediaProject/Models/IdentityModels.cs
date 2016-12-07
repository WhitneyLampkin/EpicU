using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SocialMediaProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<CommentModels> UserComments { get; set; }
        public virtual ICollection<ChatModels> UserChats { get; set; }
        public virtual ICollection<FriendshipModels> RequestedFriendships { get; set; }
        public virtual ICollection<FriendshipModels> AcceptedFriendships { get; set; }
        public virtual ICollection<MessageModels> UserMessages { get; set; }

        public int ProfileId { get; set; }

        //Just incase I cannot get the Image to work, I will add this property so I don't have to do a migration later.
        public string Picture { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[] ProfilePicture { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Date of Birth")]
        public System.DateTime Birthdate { get; set; }

        public string DisplayName{
            get{
                string dspFirstName =
                string.IsNullOrWhiteSpace(this.FirstName) ? "" : this.FirstName;
                string dspMiddleInitial =
                    string.IsNullOrWhiteSpace(this.MiddleInitial) ? "" : this.MiddleInitial;
                string dspLastName =
                    string.IsNullOrWhiteSpace(this.LastName) ? "" : this.LastName;

                return string
                    .Format("{0} {1}. {2}", dspFirstName, dspMiddleInitial, dspLastName);
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
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
            modelBuilder.Entity<IdentityUserLogin>().
                HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().
                HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().
                HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}