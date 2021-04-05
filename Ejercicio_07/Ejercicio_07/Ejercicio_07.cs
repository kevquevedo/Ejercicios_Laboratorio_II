using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";

            Console.Write("Por favor, ingrese su fecha de nacimiento (DDMMAAAA): ");

            //Registro y parseo de una fecha ingresada por consola.
            DateTime fechaNac = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            //Registro de hora actual de maquina.
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine($"NAC: {fechaNac.ToShortDateString()} / ACT: {fechaActual.ToShortDateString()}");

            //CALCULAR LA CANTIDAD DE DIAS VIVIDOS.
            //Esto uso para calcular la diferencia entre datos DateTime. 
            //Su resta devuelve un int/TimeSpan.
            int cantDias = (fechaActual - fechaNac).Days;
            Console.WriteLine($"La cantidad de dias vividos es: {cantDias}");

            Console.ReadKey();
        }
    }
}
