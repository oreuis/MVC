using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NController : Controller
    {
        // GET: N
        public ActionResult Index()
        {
            return View(new Class1()); 
        }


        [HttpPost]

        public ActionResult Index(Class1 c,string wykonaj)
        {
            if(wykonaj == "add")
            {
                c.trzy = c.jeden + c.dwa;
            }

            else if (wykonaj == "min")
            {
                c.trzy = c.jeden - c.dwa;
            }

            return View(c);
        }

    }
}