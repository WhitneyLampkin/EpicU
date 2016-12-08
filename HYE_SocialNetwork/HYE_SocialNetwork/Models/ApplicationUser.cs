using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace HYE_SocialNetwork.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Picture { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[] ProfilePicture { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(1)]
        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public System.DateTime Birthdate { get; set; }

        public string DisplayName
        {
            get
            {
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
}