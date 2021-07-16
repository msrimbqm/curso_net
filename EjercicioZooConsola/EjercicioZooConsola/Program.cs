using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZooConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo una instancia de cada tipo de animal con los contructores con parametros

            Mamifero animal1 = new Mamifero("Elefante","Simba",1345,3);
            Ave animal2 = new Ave("Colibri", "Pipin",3,5,"Rojo",100);
            Insecto animal3 = new Insecto("Mosca","punetera",1,8,true);

            animal1.queClaseDeAnimalEres();
            animal2.queClaseDeAnimalEres();
            animal3.queClaseDeAnimalEres();
            Console.ReadLine();






        }
    }
}
