using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant_Rater_MVC.Models;

namespace Restaurant_Rater_MVC.Controllers
{
    public class RestaurantController : Controller
    {
        private RestuarantDbContext _db = new RestuarantDbContext();
        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }

    }
}