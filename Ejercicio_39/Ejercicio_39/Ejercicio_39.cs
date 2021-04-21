using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_39
{
    class Ejercicio_39
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 39";

            Sobreescrito prueba = new SobreSobreescrito();
            SobreSobreescrito prueba2 = new SobreSobreescrito();
            
            
            Console.WriteLine(prueba.MiMetodo());
            Console.WriteLine(prueba2.MiMetodo());

            Console.ReadKey();
        }
    }
}
