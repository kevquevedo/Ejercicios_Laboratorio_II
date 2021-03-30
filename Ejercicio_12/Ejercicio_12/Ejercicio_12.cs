using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 12";

            int acumulador = 0;
            bool respuesta = true;

            do
            {
                Console.Write("Por favor, ingrese un numero entero: ");
                //Valido si el valor ingresado por el Usuario es un numero entero.
                if (int.TryParse(Console.ReadLine(), out int valorIngresado))
                {
                    acumulador += valorIngresado;//Acumulo el valor ingresado.
                    Console.WriteLine("¿Continuar? (S/N): ");
                    //Valido si el valor ingresado por el Usuario es un caracter.
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

                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero entero.");
                }
                
            } while (respuesta);

            Console.WriteLine($"El numero acumulado es: {acumulador}");
            Console.ReadKey();
        }
    }
}
