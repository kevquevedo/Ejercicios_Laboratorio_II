using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            OtraClase otra = new OtraClase();

            try
            {
                otra.MetodoOtraClase();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
