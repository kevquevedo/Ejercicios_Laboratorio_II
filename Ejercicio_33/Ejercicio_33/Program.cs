using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_33";

            Libro libro1 = new Libro();

            libro1[0] = "Kevin - Pagina 1";
            libro1[1] = "Agustina - Pagina 2";
            libro1[2] = "German - Pagina 3";
            libro1[6] = "Esto esta mal";
            libro1[2] = "TE PISE - Pagina 2";


            Console.WriteLine($"Devuelve: {libro1[0]}");
            Console.WriteLine($"Devuelve: {libro1[1]}");
            Console.WriteLine($"Devuelve: {libro1[2]}");
            Console.WriteLine($"Devuelve: {libro1[4]}");
            Console.WriteLine($"Devuelve: {libro1[3]}");
            Console.ReadKey();
        }
    }
}
