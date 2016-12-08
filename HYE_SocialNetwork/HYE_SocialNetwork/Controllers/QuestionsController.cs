using HYE_SocialNetwork.Models;
using HYE_SocialNetwork.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HYE_SocialNetwork.Controllers
{
    public class QuestionsController : Controller
    {
        private ApplicationDbContext db;

        public QuestionsController()
        {
            db = new ApplicationDbContext();       
        }

        // GET: Questions
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken] //Prevents CSRF Attacks
        public ActionResult Create(HYEQuestion viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            var currentUserId = User.Identity.GetUserId();
            var currentUser = db.Users.Single(u => u.Id == currentUserId);

            var question = new HYEQuestion
            {
                Inquirer = currentUser,
                DateTime = DateTime.Now,
                Question = viewModel.Question
            };

            db.HYEQuestions.Add(question);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}