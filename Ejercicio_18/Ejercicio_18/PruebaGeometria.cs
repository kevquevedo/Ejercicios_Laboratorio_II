using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace Ejercicio_18
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(1, 3);
            Punto vertice2 = new Punto(4, 5);
            Rectangulo rect = new Rectangulo(vertice1, vertice2);

            //PRUEBA DE AREA Y PERIMETRO
            Console.WriteLine($"El Perimetro del Rectangulo es: {rect.Perimetro()}");
            Console.WriteLine($"El Area del Rectangulo es: {rect.Area()}");

            //SEGUNDA PRUEBA DE PERIMETRO (PARA VERIFICAR QUE NO VUELVA A CALCULARLO).
            Console.WriteLine($"El Perimetro del Rectangulo es: {rect.Perimetro()}");

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" ");
            //MOSTRAR DATOS RECTANGULO
            Console.WriteLine($"{Rectangulo.MostrarDatos(rect)}");

            Console.ReadKey();
        }
    }
}
