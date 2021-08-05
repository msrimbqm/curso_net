using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolaclasesrepaso
{
    class Producto
    {
        // atributos ---------------------------

        private string nombre;
        private double precio;
        private string categoria;
        

        // propiedades -------------------------


        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
      
        
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }

         }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }

        }

        // constructores con trs y dos parametros-----------------------

        public Producto (string p1, double p2, string p3)
        {
            this.nombre = p1;
            this.precio = p2;
            this.categoria = p3;

        }


        public Producto(string p1, double p2)
        {
            this.nombre = p1;
            this.precio = p2;
            
         }

        public Producto()
        { }

        // metodos ----------------------------------

        public void mostrar()
        {

            Console.WriteLine(Nombre + " de precio " + Precio + " de categoria " + Categoria);
        }










    }
}
