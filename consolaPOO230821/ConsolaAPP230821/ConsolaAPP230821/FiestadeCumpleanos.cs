using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPP230821
{
    public class FiestadeCumpleanos:Fiesta

    {

        // atributos --------------------------------------

        private int TamanoPastel;
        private string TextoPastel;


        // propiedades -----------------------------------
        public int PTamanoPastel
        {
            get { return TamanoPastel; }
            set { TamanoPastel = value; }
        }

        public string PTextoPastel
        {
            get { return TextoPastel; }
            set { TextoPastel = value; }
        }


        // constructores ----------------------------------

        public FiestadeCumpleanos(int b1, decimal b2, decimal b3, decimal b4, bool b5, int b6, string b7) : base(b1, b2, b3, b4, b5)
        {
            TamanoPastel = b6;
            TextoPastel = b7;
        }


        public FiestadeCumpleanos()
        {
        }


        // metodos ----------------------------------

        public  void CalcularCostoDeDecoracion()
        {
            // cambiar valor de coste de decoracion segun numero de personas

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


            decimal total = 0;
            int tarta = 0;
            if (PNumeroDePersonas<=4) {
                tarta = 50;
            }
            else{
                tarta = 100;
            }
            total = (PNumeroDePersonas* PCostoDeDecoracion) + (PNumeroDePersonas * PCostoComidadepPorPersona) + tarta+ PBonoExtra;
            Console.WriteLine("El coste tota de la fiesta:" + total.ToString());
            Console.ReadLine();







        }



    }
}
