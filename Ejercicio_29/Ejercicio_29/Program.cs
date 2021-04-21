using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_29";

            Equipo equipo = new Equipo(2, "KEKE TEAM");

            Jugador jug1 = new Jugador(38585829, "Kevin");
            Jugador jug2 = new Jugador(38585829, "Kevin");
            Jugador jug3 = new Jugador(24242424, "Agustina");
            Jugador jug4 = new Jugador(23232323, "German");

            if(equipo + jug1)
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
