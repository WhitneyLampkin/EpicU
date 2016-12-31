using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    [RoutePrefix("")]
    //Adds the prefix to all the Routes
    public class HomeController : Controller
    {
        public IEnumerable<NewsItem> NewsItems
        {
            get
            {
                var items = new List<NewsItem>();
                for (int i = 0; i < 10; i++)
                {
                    items.Add(new NewsItem
                    {
                        Id = i,
                        Title = "My Title " + i,
                        Body = ""
                    });
                }
                return items;
            }
        }

        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("News")]
        public ActionResult News()
        {
            

            return View(NewsItems);
        }

        [Route("News/{id:int}")]
        public ActionResult NewsDetail(int id)
        {
            var item = NewsItems.FirstOrDefault(c => c.Id == id);

            return View(item);
        }
    }
}