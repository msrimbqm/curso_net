using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;









namespace MVC1.Controllers
{

   
       



    public class BibliotecaController : Controller
    {
        static biblioteca mibiblioteca = new biblioteca();

        // GET: Biblioteca
        public ActionResult Index()
        {
            return View(mibiblioteca.Libros.ToList());
        }

        // GET: Biblioteca/Details/5
        public ActionResult Details(int id)
        {
            return View(mibiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // GET: Biblioteca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                mibiblioteca.Libros.Add(new libro
                {
                    Isbn = (mibiblioteca.Libros.Count() + 1).ToString(),
                    Titulo = collection["Titulo"], 
                    TipoLibro = collection["TipoLibro"]
                                        
                    });

               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Edit/5
        public ActionResult Edit(int id)
        {

            return View(mibiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                foreach (libro l in mibiblioteca.Libros)
                {
                    if (l.Isbn == id.ToString())
                    {
                        l.Titulo = collection["Titulo"];
                        l.TipoLibro = collection["TipoLibro"];

                    }

                }




                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Delete/5
        public ActionResult Delete(int id)
        {
          
            return View(mibiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                foreach(libro l in mibiblioteca.Libros)
                {
                    if (l.Isbn == id.ToString()) mibiblioteca.Libros.Remove(l);

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
