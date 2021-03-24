using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_19
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";

            string text1 = "HOLA";
            string text2 = "MUNDO";

            Sumador sumador = new Sumador(15);
            Console.WriteLine(sumador.Sumar(text1, text2));


            Sumador sumador1 = new Sumador(25);

            long resultado = sumador + sumador1;
            Console.WriteLine(resultado);

            Sumador sumador3 = new Sumador(25);
            bool resultIgualdad = sumador1 | sumador3;
            Console.WriteLine(resultIgualdad);

            Console.ReadKey();
        }
    }
}
