using HYE_SocialNetwork.Models;
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
        public ActionResult Create()
        {
            return View();
        }
    }
}