using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolaclasesrepaso
{
    class Program
    {
        static void Main(string[] args)


        {
            // lista con los objetos
            var almacen = new List<Producto>();
            int indice = 0;

            string op ="";
            String c1 = "";
            string c3 = "";
            double c2 = 0;
            double Total = 0; ;

            // creo dos objetos con los dos contructores
            //Producto p1 = new Producto("Patatas",120,"vegetales");
            //Producto p2 = new Producto("Chorizos",15);

            // vista menu

            do

            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - CREAR ARTICULO ");
                Console.WriteLine("2 - HACER PEDIDO");
                Console.WriteLine("3 - MOSTRAR EL TOTAL + IVA");
                Console.WriteLine("4 - SALIR");
                Console.WriteLine("INTRODUZCA OPCION:");

                op = Console.ReadLine();

                switch (op)
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("Introduzca nombre Producto");
                        c1 = Console.ReadLine();
                        Console.WriteLine("Introduzca Precio Producto");
                        c2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Categoria Producto");
                        c3 = Console.ReadLine();

                        Producto p3 = new Producto(c1, c2, c3);
                        
                        // meter esto en una lista de de objetos general
                                       
                        
                        almacen.Add(p3);
                        
                        break;


                    case "2":

                        // hacer pedido va a pedir el nombre producto y la cantidad solo

                        Console.Clear();
                        int num = 0;
                        
                        foreach (var x in almacen)
                        {

                            x.mostrar();
                            //Console.WriteLine(x.Nombre+" de precio "+x.Precio+" de categoria "+x.Categoria);
                            Console.WriteLine();
                            Console.WriteLine("Introduzca cantidad Producto: ");
                            num = int.Parse(Console.ReadLine());
                            Total  = (x.Precio*num)+Total;
                            Console.WriteLine();
                            
                         }
                        Console.WriteLine(Total.ToString());

                        break;

                    case "3":

                       
                        Console.WriteLine("El total es:" + Total.ToString());
                        Console.WriteLine("El IVA es:" + (Total * 0.21).ToString());
                        Console.WriteLine("El Total con IVA  es:" + (Total * 1.21).ToString());
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        break;



                    default:
                        Console.WriteLine("Has introducido una opcion erronea");
                        Console.ReadLine();

                        break;
                }

            } while (op != "4");
        }
     }
}
