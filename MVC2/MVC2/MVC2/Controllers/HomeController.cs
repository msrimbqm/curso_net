using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CalcularEdad()
        {
            return View();
        }


        [HttpPost]

        public ActionResult CalcularEdad(int txtan, string txtn)
        {
            int actual = DateTime.Now.Year;
            int edad = actual - txtan;
            ViewBag.e = edad;
            ViewBag.n = txtn;
            ViewBag.an = txtan;
            return View();


        }

        public ActionResult CalculaNumeros()
        {
            return View();
        }


        [HttpPost]

        public ActionResult CalculaNumeros(int txtn1, int txtn2)
        {
            // txtn1, y txtn2 son los nombres de la vista name
            int op1 = txtn1;
            int op2 = txtn2;

            // estos viewbag son los que muestran luegos los equipos

            ViewBag.r1 = op1 + op2;
            ViewBag.r2 = op1 - op2;
            ViewBag.r3 = op1 * op2;
            ViewBag.r4 = op1 / op2;

            return View();
        }


        public ActionResult Conversion()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Conversion (float txtn1, float txtn2)
        {
            // txtn1, y txtn2 son los nombres de la vista name
            float op1 = txtn1;
            float op2 = txtn2;

            // estos viewbag son los que muestran luegos los equipos

            // casar a Farenhait


            ViewBag.r1 = ((op1*9)/5)+32;
            ViewBag.r2 = (op2 * 25, 5);
                                  
            return View();
        }


        public ActionResult Descuento()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Descuento(float txtn1, float txtn2)
        {
            // calcular 
            float op1 = txtn1;
            float op2 = txtn2;
            float dif = 0;
            float dto = 0;

            // estos viewbag son los que muestran luegos los equipos

            // calcular descuento en porcentaje


           dif = op1 - op2;
           dto = (dif * 100) / op1;

          ViewBag.r1 = dto;
            
           return View();
        }

        public ActionResult Estadistica()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Estadistica(int txtsuspensos, int txtaprobados, int txtnotables, int txtsobresalientes )
        {
            // recibo los campos del formulario y calculo

            
            int superaron = 0;
            int totales = 0;

            superaron = txtaprobados + txtnotables + txtsobresalientes;
            totales = superaron + txtsuspensos;

            // calcular 

            // estos viewbag son los que muestran luegos los equipos
            // % superaron, suspensos, aprobados, notables, sobresalientes
            ViewBag.r1 = (superaron * 100) / totales;
            ViewBag.r2 = (txtsuspensos * 100) / totales;
            ViewBag.r3 = (txtaprobados * 100) / totales;
            ViewBag.r4 = (txtnotables * 100) / totales;
            ViewBag.r5 = (txtsobresalientes * 100) / totales;


            return View();
        }






    }
}