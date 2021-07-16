using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZooConsola
{
    class Mamifero:Animal
    {
        // constructor
        public Mamifero() { }

        public Mamifero(string p1, string p2, double p3, int p4):base (p1,p2,p3,p4)
        {

        }

        public override void  queClaseDeAnimalEres()
        {
            // redefine el metodo de la clase padre

            Console.WriteLine("Soy un mamifero llamado:" + this.Nombre);
            Console.WriteLine("de la especie:" + this.Especie);
            Console.WriteLine("Peso en Kg:" + this.Peso.ToString());
            Console.WriteLine("Estoy en la Jaula:" + this.Jaula.ToString());

        }


    }
}
