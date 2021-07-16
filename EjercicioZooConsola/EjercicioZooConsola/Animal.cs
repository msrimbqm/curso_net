using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZooConsola
{
    public abstract class Animal
    {// atributos-------------------------------------
        protected string especie;
        protected string nombre;
        protected double peso;
        protected int jaula;
// propiedades ------------------------------------------
        public string Especie
        {
            get { return especie; }
            set { especie = value; }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }

        }

        public int Jaula
        {
            get { return jaula; }
            set { jaula = value; }

        }
        // Constructores-----------------------------------

        public Animal() { }

        public Animal(string p1, string p2, double p3, int p4)
        {
            this.Especie = p1;
            this.Nombre = p2;
            this.Peso = p3;
            this.Jaula = p4;
        
        }

// metodos-------------------------------------


        public virtual void queClaseDeAnimalEres()
        {


        }

    }


}
