using gogoday.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gogoday.Controllers
{
    public class OrgController : Controller
    {
        public OrgTreeHelper helper = new OrgTreeHelper();
        //
        // GET: /Org/

        public ActionResult Index()
        {
            ViewBag.OrgHelper = helper;
            return View();
        }

    }
}
