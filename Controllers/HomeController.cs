using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// Asegúrate de tener el namespace correcto para el modelo Tripulant

namespace onePice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Barco()
        {
            ViewBag.Message = "barco";
            return View();
        }

         
    }
    public class Tripulant
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Rango { get; set; }
    }
}