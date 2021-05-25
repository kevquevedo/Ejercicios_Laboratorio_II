using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_36
{
    class Ejercicio_36
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_36";

            Competencia competencia = new Competencia(28, 2, Competencia.TipoCompetencia.AutoF1);
            AutoF1 autoKev = new AutoF1(10, "Ferrari", 143);
            AutoF1 autoGer = new AutoF1(10, "Ferrari");
            AutoF1 autoAgus = new AutoF1(5, "McClaren");
            AutoF1 autoGer2 = new AutoF1(4, "Lamborghini");
            Motocross moto1 = new Motocross(12, "Kawasaki", 600);

            if (competencia + autoKev)
            {
                Console.WriteLine("Se agregó auto a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ.");
            }
            if (competencia + moto1)
            {
                Console.WriteLine("Se agregó MOTO a la competencia.");
            }
            else
            {
                Console.WriteLine("NO SE MOTO AGREGÓ.");
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
            Console.WriteLine("-----------------AUTO------------------------");
            Console.WriteLine(autoKev.MostrarDatos());
            Console.WriteLine("-----------------MOTO------------------------");
            Console.WriteLine(moto1.MostrarDatos());

            Console.ReadKey();
        }
    }
}
