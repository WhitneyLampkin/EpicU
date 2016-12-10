using HYE_SocialNetwork.Models;
using HYE_SocialNetwork.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web.Mvc;

namespace HYE_SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            DateTime nowMinus5Days = DateTime.Now.AddDays(-5);

            var newQuestions = db.HYEQuestions
                .Include(q => q.Inquirer)
                .Where(q => q.DateTime > nowMinus5Days);

            var viewModel = new HomeViewModel
            {
                NewQuestions = newQuestions,
                ShowActions = User.Identity.IsAuthenticated
            };

            return View(viewModel);
        }

        // Only Authenticated users can access thier profile
        [Authorize]
        public ActionResult Profile()
        {
            // Instantiate the ASP.NET Identity system
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            // Get the current logged in User and look up the user in ASP.NET Identity
            var currentUser = manager.FindById(User.Identity.GetUserId());

            // Recover the profile information about the logged in user
            ViewBag.DisplayName = currentUser.DisplayName;
            ViewBag.Birthday = currentUser.Birthdate;
            ViewBag.Gender = currentUser.Gender;
            ViewBag.Email = currentUser.Email;

            return View();
        }

        [Authorize]
        public ActionResult AllUsers()
        {
            //// Instantiate the ASP.NET Identity system
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //var allUsers = manager.Users.ToList();

            //ViewBag.AllUsers = allUsers;

            var users = manager.Users.ToList();

            var ViewModel = new AllUsersViewModel();
            ViewModel.HYEUsers = users; 

            return View(ViewModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}