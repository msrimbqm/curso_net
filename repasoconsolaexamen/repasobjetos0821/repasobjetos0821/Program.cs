using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasobjetos0821
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Myempleado = new Empleado("Marcos","Sastre","10880301J","nose","Fijo",0);
            Myempleado.CargarDatos();
            Myempleado.CrearSueldo();
            Myempleado.mostrar();
            Console.WriteLine();



            
            Cliente MyCliente = new Cliente("Mabel", "Madueno", "10890379V", "nose2", "Jefe", "");
            MyCliente.CargarDatos();
            MyCliente.GenerarCodigo();
            MyCliente.mostrar();

            Console.ReadLine();

        }
    }
}
