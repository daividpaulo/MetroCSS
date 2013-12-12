using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class PrincipalController : Controller
    {
        //
        // GET: /Principal/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialTeste()
        {
            return PartialView("_PartialTeste");
        }

        public ActionResult Inicio()
        {

            return View();
        }

        public ActionResult login()
        {
            return View();
        }

    }
}
