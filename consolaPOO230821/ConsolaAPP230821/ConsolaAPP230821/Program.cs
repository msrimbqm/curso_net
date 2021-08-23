using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPP230821
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Fiesta de Gala");
                Console.WriteLine("2- Fiesta de Cumple");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Introduzca tipo fiesta (1/2):");
                op = Console.ReadLine();
                string x;

                if (op=="1")
                {
                    // pide datos fiesta de gala
                    
                    FiestaDeGala MyFG1 = new FiestaDeGala();
                    Console.WriteLine("Numero personas:");
                    MyFG1.PNumeroDePersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Decoramos: (S)?");
                    x = Console.ReadLine();
                    if (x == "S") MyFG1.PDecora = true; else MyFG1.PDecora = false;
                    Console.WriteLine("Coste Comida PAX:");
                    MyFG1.PCostoComidadepPorPersona = decimal.Parse(Console.ReadLine());
                    MyFG1.PBonoExtra = 0;
                    if (MyFG1.PNumeroDePersonas > 12)
                    {
                        // mas de 12 personsa bono extra a meter
                        Console.WriteLine("Coste Bono extra:");
                        MyFG1.PBonoExtra = decimal.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Opcion Extra de Gala: (S) ? ");
                    x = Console.ReadLine();
                    if (x == "S") MyFG1.POpcionExtra = true; else MyFG1.POpcionExtra = false;
                    MyFG1.CalcularCostoDeDecoracion();
                    MyFG1.CalcularCosto();
                
                }

                if (op == "2")
                {
                    // pide datos fiesta de gala

                    FiestadeCumpleanos MyFC1 = new FiestadeCumpleanos();
                    Console.WriteLine("Numero personas:");
                    MyFC1.PNumeroDePersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Decoramos: (S)?");
                    x = Console.ReadLine();
                    if (x == "S") MyFC1.PDecora = true; else MyFC1.PDecora = false;
                    Console.WriteLine("Coste Comida PAX:");
                    MyFC1.PCostoComidadepPorPersona = decimal.Parse(Console.ReadLine());
                    MyFC1.PBonoExtra = 0;
                    if (MyFC1.PNumeroDePersonas > 12)
                    {
                        // mas de 12 personsa bono extra a meter
                        Console.WriteLine("Coste Bono extra:");
                        MyFC1.PBonoExtra = decimal.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Tamaño del pastel:");
                    MyFC1.PTamanoPastel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Texto del pastel:");
                    MyFC1.PTextoPastel = Console.ReadLine();
                    MyFC1.CalcularCostoDeDecoracion();
                    MyFC1.CalcularCosto();                               
                   
                }


            }
             while( (op != "1") && (op != "2") && (op != "0"));


                
        


        }
    }
}
