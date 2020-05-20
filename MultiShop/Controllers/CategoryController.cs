using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiShop.Models;
namespace MultiShop.Controllers
{
    public class CategoryController : Controller
    {
        MultiShopDbContext db = new MultiShopDbContext();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}