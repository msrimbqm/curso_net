using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

    }
}