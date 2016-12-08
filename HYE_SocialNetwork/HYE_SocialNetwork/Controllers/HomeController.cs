using HYE_SocialNetwork.Models;
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
           
            return View(newQuestions);
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