using CottingsleyWeb.Models;
using CottingsleyWebService;
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
            Register register = new Register();
           var a = register.GetAllQuestions();

            return Json("Success");
        }
    }
}
