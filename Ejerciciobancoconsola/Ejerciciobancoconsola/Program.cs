using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciobancoconsola
{
    class Program
    {
        static void Main(string[] args)
         {
            string op = "";
            Cuenta cta=new Cuenta();
            float aux=0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 Crear Cuenta ");
                Console.WriteLine("2 Depositar ");
                Console.WriteLine("3 Retirar ");
                Console.WriteLine("4 Saldo ");
                Console.WriteLine("5 Salir ");
                op = Console.ReadLine();



                switch (op)
                {
                    case ("1"):
                        cta = new Cuenta();
                        Console.WriteLine("Cuenta Creada");
                        Console.ReadLine();
                        break;

                    case ("2"):
                        Console.Clear();
                        Console.WriteLine("Importe a ingresar");
                        aux = float.Parse(Console.ReadLine());
                        cta.depositar(aux);
                        break;
                    case ("3"):
                        Console.Clear();
                        Console.WriteLine("Importe a retirar");
                        aux = float.Parse(Console.ReadLine());
                        cta.retirar(aux);
                        break;
                    case ("4"):
                        cta.consultar();
                        break;

                    default:
                        Console.WriteLine("Saliendo");
                        Console.ReadLine();
                        break;

                }
            }
            while (op != "5");





            }
    }
}
