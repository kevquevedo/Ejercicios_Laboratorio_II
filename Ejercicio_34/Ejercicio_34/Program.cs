using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_34";

            Camion camion = new Camion(6, 2, Colores.Negro, 16, 10000);
            Moto moto = new Moto(2, 0, Colores.Rojo, 600);
            Automovil auto = new Automovil(4,4,Colores.Azul,5,5);

            Console.WriteLine("==============CAMION=====================");
            Console.WriteLine(camion.MostrarDatos());    
            Console.WriteLine("==============MOTO=====================");
            Console.WriteLine(moto.MostrarDatos());
            Console.WriteLine("==============AUTO=====================");
            Console.WriteLine(auto.MostrarDatos());

            Console.ReadKey();
        }
    }
}
