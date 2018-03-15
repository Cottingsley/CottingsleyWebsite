using CottingsleyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CottingsleyWeb.Controllers
{
    public class SchoolController : Controller
    {

        public ActionResult ContactUs()
        {
            return PartialView("~/Views/PartialViews/_ContactUs.cshtml", new UserRegistrationModel());
        }

        [HttpPost]
        public ActionResult Registration(UserRegistrationModel values) {
            var internalValue = values;
            return Json("Success");
        }
    }
}
