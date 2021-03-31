using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_14
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 14";

            Console.WriteLine($"El area de un Cuadrado de 6 es: {CalculoDeArea.CalcularCuadrado(6)}");
            Console.WriteLine($"El area de un Circulo de 7 es: {CalculoDeArea.CalcularCirculo(7):0.00}");
            Console.WriteLine($"El area de Triangulo de 3 de base y 4 de altura es: {CalculoDeArea.CalcularTriangulo(3,4)}");

            Console.ReadKey();
        }
    }
}
