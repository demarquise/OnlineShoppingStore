using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Models;

namespace OnlineShoppingStore.Controllers
{
    public class ShirtController : Controller
    {
        // GET: Shirt
        public ActionResult Supremeshirt()
        {
            shirts SP = new shirts() { supreme = "Suprme Shirt XL" };
           


            return View(SP);
        }
    }
}