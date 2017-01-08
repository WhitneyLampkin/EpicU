using HYE_SocialNetwork.Models;
using HYE_SocialNetwork.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HYE_SocialNetwork.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext db;

        
        public ProfileController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Profile
        [Authorize]
        public ActionResult Index()
        {

            var currentUserId = User.Identity.GetUserId();

            var answers = db.HYEAnswers
                .Where(a => a.ResponderId == currentUserId)
                .ToList();

            var questions = db.HYEQuestions
                .Where(a => a.InquirerId == currentUserId)
                .ToList();

            var followers = db.Followings
                .Where(u => u.FolloweeId == currentUserId)
                .Select(f => f.Follower)
                .ToList();

            var followees = db.Followings
                .Where(u => u.FollowerId == currentUserId)
                .Select(f => f.Followee)
                .ToList();

            var viewModel = new ProfileViewModel
            {
                User = currentUserId,
                MyAnswers = answers,
                MyQuestions = questions,
                MyFollowees = followees,
                MyFollowers = followers
            };

            return View(viewModel);
        }

        //public List<>
    }
}