using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 17";

            //PRUEBA BOLIGRAFO AZUL
            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Console.ForegroundColor = boliAzul.GetColor();
            Console.WriteLine($"Capacidad del Boligrafo Azul inicial: {boliAzul.GetTinta()}");
            boliAzul.Pintar(3, out string boliAzul1);
            Console.WriteLine($"Boligrafo Azul: {boliAzul1}");
            Console.WriteLine($"Capacidad del Boligrafo Azul final: {boliAzul.GetTinta()}");

            //SEPARADOR
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ");

            //PRUEBA BOLIGRAFO ROJO
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);
            Console.ForegroundColor = boliRojo.GetColor();
            Console.WriteLine($"Capacidad del Boligrafo Rojo inicial: {boliRojo.GetTinta()}");
            boliRojo.Pintar(7, out string boliRoja1);
            Console.WriteLine($"Boligrafo Roja: {boliRoja1}");
            Console.WriteLine($"Capacidad del Boligrafo Rojo final: {boliRojo.GetTinta()}");


            Console.ReadKey();
        }
    }
}
