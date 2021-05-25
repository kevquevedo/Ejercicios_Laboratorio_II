using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Ejercicio_40
{
    class Ejercicio_40
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_40";

            // Mi central
            Centralita centralita = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            if(centralita + l1)
            {
                Console.WriteLine("Se agrego ok!!");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ!!");
            }
            if (centralita + l2)
            {
                Console.WriteLine("Se agrego ok!!");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ!!");
            }
            if (centralita + l3)
            {
                Console.WriteLine("Se agrego ok!!");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ!!");
            }
            if (centralita + l4)
            {
                Console.WriteLine("Se agrego ok!!");
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ!!");
            }

            centralita.OrdenarLlamadas();
            Console.WriteLine("========================================================");
            Console.WriteLine(centralita.ToString());
            Console.ReadKey();
        }
    }
}
