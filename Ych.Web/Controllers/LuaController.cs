using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ych.Web.Controllers
{
    public class LuaController : Controller
    {
        //
        // GET: /Lua/

        public ActionResult Index()
        {
            ViewBag.Header = "Everything is Rebuliding by Lua";
            return View();
        }

    }
}
