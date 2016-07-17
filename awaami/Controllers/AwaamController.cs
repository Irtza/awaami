using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace awaami.Controllers
{
    public class AwaamController : Controller
    {
        // GET: Awaam
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterPost()
        {
            return RedirectToAction("login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult ViewIssues()
        {

            return View();
        }

        public ActionResult Authorities()
        {

            return View();
        }

    }
}