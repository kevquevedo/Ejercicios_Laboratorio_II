using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_35";

            Equipo equipo = new Equipo(2, "KEKE TEAM");

            Jugador jug1 = new Jugador(38585829, "Kevin", 8, 2);
            Jugador jug2 = new Jugador(38585829, "Kevin");
            Jugador jug3 = new Jugador(24242424, "Agustina", 15, 3);
            Jugador jug4 = new Jugador(23232323, "German");

            Console.WriteLine(jug1.MostrarDatos());
            Console.WriteLine("---------------------------");
            Console.WriteLine(jug3.MostrarDatos());
            Console.WriteLine("---------------------------");

            DirectorTecnico dt1 = new DirectorTecnico("Julian", DateTime.Parse("23/09/1994"));
            Console.WriteLine(dt1.MostrarDatos());
            Console.WriteLine("---------------------------");
            DirectorTecnico dt2 = new DirectorTecnico("Fabian", DateTime.Parse("01/03/1998"));
            Console.WriteLine(dt2.MostrarDatos());
            Console.WriteLine("---------------------------");



            if (equipo + jug1)
            {
                Console.WriteLine("Lo agregué OK al jugador 1.");
            }
            else
            {
                Console.WriteLine("No pude agregar al jugador 1.");
            }

            if (equipo + jug2)
            {
                Console.WriteLine("Lo agregué OK al jugador 2.");
            }
            else
            {
                Console.WriteLine("No pude agregar al jugador 2.");
            }

            if (equipo + jug3)
            {
                Console.WriteLine("Lo agregué OK al jugador 3.");
            }
            else
            {
                Console.WriteLine("No pude agregar al jugador 3.");
            }

            if (equipo + jug4)
            {
                Console.WriteLine("Lo agregué OK al jugador 4.");
            }
            else
            {
                Console.WriteLine("No pude agregar al jugador 4.");
            }

            Console.ReadKey();
        }
    }
}
