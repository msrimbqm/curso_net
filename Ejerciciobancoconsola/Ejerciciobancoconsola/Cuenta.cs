using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciobancoconsola
{
    class Cuenta
    {
        private string numeroCuenta;
        private string nombreCliente;
        private float saldo=0;

        public string NumeroCuenta{
            get { return numeroCuenta;}
            set {numeroCuenta=value;}
        }   

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }

        }

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }

        }

        public void depositar (float p1)
        {
            this.Saldo += p1;
        }

        public void retirar(float p1)
        {
            
            if (saldo < p1)
            {
                Console.WriteLine("Error saldo no suficiente");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                this.Saldo -= p1;

            }
                          
        }

        public void consultar()
        {
            Console.Clear();
            Console.WriteLine("El saldo es :" + this.Saldo.ToString());
            Console.ReadLine();
            Console.Clear();

        }


    }
}
