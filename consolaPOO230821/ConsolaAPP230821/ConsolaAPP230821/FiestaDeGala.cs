using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPP230821
{
    public class FiestaDeGala:Fiesta
    {

        // atributos --------------------------------------

        private decimal CostePromedioPorPersona;
        private bool OpcionExtra;


        // propiedades -----------------------------------
        public decimal PCostePromedioPorPersona
        {
            get { return CostePromedioPorPersona; }
            set { CostePromedioPorPersona = value; }
        }

        public bool POpcionExtra
        {
            get { return OpcionExtra; }
            set { OpcionExtra = value; }
        }


        // constructores ----------------------------------

        public FiestaDeGala(int b1, decimal b2, decimal b3, decimal b4, bool b5,decimal b6, bool b7):base(b1, b2, b3, b4 ,b5)
        {
            CostePromedioPorPersona = b6;
            OpcionExtra = b7;
        }


        public FiestaDeGala()
        { 
        }


        // metodos ----------------------------------------------

        public  void CalcularCostoDeDecoracion()
        {
            
            if (PDecora == true)
            {
                if (PNumeroDePersonas <= 20)

                {
                    PCostoDeDecoracion = 160;
                }
                else
                {
                    PCostoDeDecoracion = 200;
                }
            }
            else {

                PCostoDeDecoracion = 0;
            }
                
        }

        public void CalcularCosto() 
        {
            // calcula el coste de la fiesta, sera el (coste de decoracion) + (numero de personas * costecomida , este lo pide ) + (numero de personas * bono extra) 

            decimal total = 0;
            total = (PNumeroDePersonas*PCostoDeDecoracion) + (PNumeroDePersonas * PCostoComidadepPorPersona) + (PNumeroDePersonas * CostePromedioPorPersona)+PBonoExtra;
            Console.WriteLine("El coste tota de la fiesta:" + total.ToString());
            Console.ReadLine();
                               
        }

        public void SetOpcionEXTRA()
        {
            // si se exta esta activo calcual costepromoediopersona del extra segun 

            if (OpcionExtra == true)
            {
                CostePromedioPorPersona = 40;
            }
            else
            {
                CostePromedioPorPersona = 0;
            }

         }



    }
}
