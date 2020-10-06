using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class paginasController : Controller
    {
        // GET: pagina
        public ActionResult Index()
        {
            ViewBag.Pagina = new Pagina().Lista();
            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}