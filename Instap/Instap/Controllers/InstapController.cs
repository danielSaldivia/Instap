using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Instap.Controllers
{
    public class InstapController : Controller
    {
        // GET: Instap
        public ActionResult Index()
        {
            return View();
        }
    }
}