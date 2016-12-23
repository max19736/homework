using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class memberController : Controller
    {
        // GET: member
        public ActionResult memberIndex()
        {
            return View();
        }
    }
}