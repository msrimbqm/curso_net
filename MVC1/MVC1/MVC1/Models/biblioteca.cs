using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC1.Models;

namespace MVC1.Models
{
    public class biblioteca
    {
        public List<libro> Libros { get; set; }
        
        public  biblioteca()
        {
            Libros = new List<libro>
            {
                new  libro  {  Isbn  =  "11122",  Titulo  =  "Los  Piratas  del  Caribe",  TipoLibro  =
                        "Novela"},  new  libro  {  Isbn  =  "22211",  Titulo  =  "Los  Pilares  de  la  tierra",
                        TipoLibro  =  "Novela"},  new  libro  {  Isbn  =  "33311",  Titulo  =  "Steve  Jobs",
                        TipoLibro =  "Biografía"} 
            };
        }

        public int NumeroLibros()
        {

            return Libros.Count();
           
        }

        public libro ObtenerPorIsbn (string isbn)
        {
            foreach (var libroBuscar in Libros)
            {
                if (libroBuscar.Isbn == isbn)
                {
                    return libroBuscar;
                }
             }
            return null;
         }




    }
}