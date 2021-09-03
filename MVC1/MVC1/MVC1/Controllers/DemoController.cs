using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            // esto  devuelve un libro solo
            //var librox = new libro { Isbn = "1122", Titulo = "El Principito", TipoLibro = "Novela" };

            // ahoa una list de libro
            var librox = new List<libro>
            {
                new libro {Isbn = "1122", Titulo = "El Principito", TipoLibro = "Novela" },
                new libro {Isbn = "1123", Titulo = "El Principito2", TipoLibro = "Novela romantica" }
            };

                     

            
            ViewBag.Mensaje = "Acceso al metodo por defecto";
            return View(librox);
        }

    }
}