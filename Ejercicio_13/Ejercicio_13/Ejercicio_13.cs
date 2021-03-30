using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 13";

            /*
            Console.Write("Por favor, ingrese un Número Entero para convertirlo a Binario: ");
            if (int.TryParse(Console.ReadLine(), out int valorEntero))
            {
                Console.WriteLine($"El numero ingresado en Binario es: {Conversor.DecimalBinario(valorEntero)}"); 
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un numero entero.");
            }
            */

            Console.Write("Por favor, ingrese un Número Binario para convertirlo a Entero: ");

            Console.WriteLine($"El numero ingresado en Binario es: {Conversor.BinarioDecimal(Console.ReadLine())}");

            Console.ReadKey();
        }
    }
}
