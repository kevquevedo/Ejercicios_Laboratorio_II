using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";

            Console.Write("Por favor, ingrese un número: ");

            if (int.TryParse(Console.ReadLine(), out int numIngresado))
            {
                //Voy iterando del 1 hasta el numero ingresado, para evaluar si es un centro numerico.
                for (int centro = 1; centro <= numIngresado; centro++)
                {
                    int acum = 0;
                    //Mientras la i, sea menos al centro numerico que estoy evaluando, lo acumulo.
                    for (int i = 1; i < centro; i++)
                    {
                        acum += i;
                    }

                    //Al contador, le voy a asignar el numero posterior al que estoy evaluando.
                    int contador = centro + 1;
                    do
                    {
                        acum -= contador;//le resto el numero del contador al acumulado.
                        contador++;//incremento el contador.
                    } while (acum > 0);

                    //Si el numero acumulado quedó en 0, significa que no tengo resto.
                    //Por lo tanto, imprimo que es un centro numerico.
                    if (acum == 0)
                    {
                        Console.WriteLine("{0} es centro numérico", centro);
                    }
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado, no es un número");
            }
                
            Console.ReadKey();
        }
    }
}
