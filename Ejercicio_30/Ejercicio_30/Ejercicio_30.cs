using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_30
{
    class Ejercicio_30
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_30";

            Competencia competencia = new Competencia(28, 2);
            AutoF1 autoKev = new AutoF1(10, "Ferrari");
            AutoF1 autoGer = new AutoF1(10, "Ferrari");
            AutoF1 autoAgus = new AutoF1(5, "McClaren");
            AutoF1 autoGer2 = new AutoF1(4, "Lamborghini");

            if(competencia + autoKev)
            {
                Console.WriteLine("Se agregó auto a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ.");
            }
            if (competencia + autoGer)
            {
                Console.WriteLine("Se agregó auto a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ.");
            }
            if (competencia + autoAgus)
            {
                Console.WriteLine("Se agregó auto a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ.");
            }
            if (competencia + autoGer2)
            {
                Console.WriteLine("Se agregó auto a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ.");
            }

            Console.WriteLine(competencia.MostrarDatos());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(autoGer2.MostrarDatos());

            Console.ReadKey();
        }
    }
}
