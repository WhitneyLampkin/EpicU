using OnlineStore.DAL;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Controllers.Item(db.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {

            }
            return View("Cart");
        }
    }
}