using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            //Pido desde el año a evaluar.
            Console.Write("Por favor, ingrese un año de inicio: ");
            int.TryParse(Console.ReadLine(), out int anioInicio);
            //Pido hasta el año a evaluar.
            Console.Write("Por favor, ingrese un año de fin: ");
            int.TryParse(Console.ReadLine(), out int anioFin);

            //Recorro los años entre los brindados por consola.
            for (int i = anioInicio; i <= anioFin; i++)
            {
                //Si el numero es divisible por 4 y no es divisible por 100, se que ee bisiesto.
                //Por lo tanto imprimo por consola.
                if ((i % 4 == 0) && !(i % 100 == 0))
                {
                    Console.WriteLine($"{i} es un año Bisiesto.");
                }
                else if (i % 400 == 0)//Pero, tambien esta la excepcion de que si tambien es divisible por 400 imprimo por consola.
                {
                    Console.WriteLine($"{i} es un año Bisiesto.");
                }
            }
            Console.ReadKey();
        }
    }
}
