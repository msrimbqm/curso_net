using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPP230821
{
    public class Fiesta

    {

        // atributos------------------------------------------
        private int NumeroDePersonas=0;
        private decimal CostoDeDecoracion = 0;
        private decimal BonoExtra = 0;
        private decimal CostoComidadepPorPersona = 0;
        private bool Decora;


        // propiedades-----------------------------------------

        public int PNumeroDePersonas
        {
            get { return NumeroDePersonas; }
            set { NumeroDePersonas = value; }
        }

        public decimal PCostoDeDecoracion 
        {
            get { return CostoDeDecoracion; }
            set { CostoDeDecoracion = value; }
        }

        public decimal PBonoExtra
        {
            get { return BonoExtra; }
            set { BonoExtra = value; }
        }

        public decimal PCostoComidadepPorPersona
        {
            get { return CostoComidadepPorPersona; }
            set { CostoComidadepPorPersona = value; }
        }

        public bool PDecora
        {
            get { return Decora; }
            set { Decora = value; }

        }


        // constructores ----------------------------------------------

        public Fiesta() { }

        public Fiesta(int p1, decimal p2, decimal p3, decimal p4, bool p5) 
        { 
            NumeroDePersonas=p1;
            CostoDeDecoracion = p2;
            BonoExtra = p3;
            PCostoComidadepPorPersona = p4;
            Decora = p5;

        }


        // metodos -----------------------------------------------


      
    }






}

