using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 22";

            NumeroDecimal objDecimal = 17;
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal2 = 3;

            
            //PRUEBA 1
            Console.WriteLine("PRUEBA 1");
            double final = objDecimal + objBinario;
            double final2 = objDecimal - objBinario;
            Console.WriteLine($"SUMA: {final}");
            Console.WriteLine($"RESTA: {final2}");
            
            Console.WriteLine("---------------------------------------");
            //PRUEBA 2
            Console.WriteLine("PRUEBA 2");
            string final3 = objBinario + objDecimal;
            string final4 = objBinario - objDecimal2;
            Console.WriteLine($"SUMA: {final3}");
            Console.WriteLine($"RESTA: {final4}");

            Console.ReadKey();
        }
    }
}
