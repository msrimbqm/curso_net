using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZooConsola
{
    class Ave:Animal
    {
        private string colorPlumaje;
        private double alturaMaximaVuelo;

        // propiedades

        public string ColorPlumaje
        {
            get { return colorPlumaje; }
            set { colorPlumaje = value; }
        }

        public double AlturaMaximaVuelo
        {
            get { return alturaMaximaVuelo; }
            set { alturaMaximaVuelo = value; }
        }


        // constructor
        public Ave() { }

        public Ave(string p1, string p2, double p3, int p4,string p5,double p6) : base(p1, p2, p3, p4)
        {
            // constructo cn parametros
            this.ColorPlumaje = p5;
            this.AlturaMaximaVuelo = p6;
        }

        public override void queClaseDeAnimalEres()
        {
            // redefine el metodo de la clase padre

            Console.WriteLine("Soy una ave llamada:" + this.Nombre);
            Console.WriteLine("de la especie:" + this.Especie);
            Console.WriteLine("Peso en Kg:" + this.Peso.ToString());
            Console.WriteLine("Estoy en la Jaula:" + this.Jaula.ToString());
            Console.WriteLine("con el plumaje de color:" + this.ColorPlumaje);
            Console.WriteLine("Con altura de vuelo maxima de:" + this.AlturaMaximaVuelo.ToString());

        }


    }

}
