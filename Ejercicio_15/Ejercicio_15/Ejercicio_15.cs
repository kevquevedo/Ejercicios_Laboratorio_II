using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 15";
            bool respuesta = true;

            do
            {
                Console.Write("Por favor, ingrese el primer numero: ");
                int.TryParse(Console.ReadLine(), out int numero1);

                Console.Write("Por favor, ingrese el segundo numero: ");
                int.TryParse(Console.ReadLine(), out int numero2);

                Console.Write("Por favor, ingrese el operador: ");
                string operador = Console.ReadLine();

                double resultado = Calculadora.Calcular(numero1, numero2, operador);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"El resultado de la operacion es: {resultado:0.00}");

                Console.Write("¿Continuar? (S/N): ");
                if (char.TryParse(Console.ReadLine(), out char ingreso))
                {
                    //Valido si el caracter NO es S ó s.
                    if (!ValidarRespuesta.ValidaS_N(ingreso))
                    {
                        respuesta = false;//Si no es S ó s, respuesta se vuelve false y sale del do-while.
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es S/N.");
                }

                Console.ReadKey();
            } while (respuesta);

        }
    }
}
