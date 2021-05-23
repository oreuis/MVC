using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MyclassController : Controller
    {
        // GET: Myclass
        public ActionResult Index()
        {
            return View(new myclass());
        }

        [HttpPost]

        public ActionResult Index(myclass c, string wykonaj)
        {
            if (wykonaj == "p1")
            {
                c.dwa = "@";
                c.cztery = "pocztowka.pl";
                c.trzy = c.jeden + c.dwa + c.cztery;
            }

            else if (wykonaj == "p2")
            {
                c.dwa = "@";
                c.cztery = "poczta.eu";
                c.trzy = c.jeden + c.dwa + c.cztery;
            }

            else
            {
                c.dwa = "@";
                c.cztery = "pczt.pl";
                c.trzy = c.jeden + c.dwa + c.cztery;
            }

            return View(c);
        }

    }
}