using CottingsleyWeb.Models;
using CottingsleyWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CottingsleyWebService.Model;

namespace CottingsleyWeb.Controllers
{
    public class SchoolController : Controller
    {

        public ActionResult ContactUs()
        {
            return PartialView("~/Views/PartialViews/_ContactUs.cshtml");
        }

        [HttpPost]
        public ActionResult Registration(SchoolRegistration values) {
            Register register = new Register();
            var registerdvalue = register.SchoolvisitorInformation(values);
            return Json("Success");
        }
    }
}
