using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 16";

            Alumno alumno1 = new Alumno("Kevin", "Quevedo", 1234);
            Alumno alumno2 = new Alumno("Agustina", "Buonvisi", 4545);
            Alumno alumno3 = new Alumno("German", "Fernandez", 8686);

            alumno1.Estudiar(2, 4);
            alumno2.Estudiar(5, 8);
            alumno3.Estudiar(7, 9);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(alumno3.Mostrar());
            
            Console.ReadKey();
        }
    }
}
