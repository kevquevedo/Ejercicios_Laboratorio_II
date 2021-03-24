using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 2";

            Console.Write("Ingrese un numero: ");
            double numIngr = int.Parse(Console.ReadLine());
            if (numIngr > 0)
            {
                double cuadrado = Math.Pow(numIngr, 2);
                double cubo = Math.Pow(numIngr, 3);
                Console.WriteLine($"El cuadrado del numero es: {cuadrado}");
                Console.WriteLine($"El cubo del numero es: {cubo}");
            }
            else
            {
                Console.WriteLine("ERROR.¡Reingresar número!");
            }
            Console.ReadKey();
        }
    }
}
