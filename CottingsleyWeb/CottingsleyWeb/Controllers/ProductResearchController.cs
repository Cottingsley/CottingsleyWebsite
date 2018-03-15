using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CottingsleyWeb.Controllers
{
    public class ProductResearchController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            return View("~/Views/Home/ProductResearch.cshtml");
        }
    }
}