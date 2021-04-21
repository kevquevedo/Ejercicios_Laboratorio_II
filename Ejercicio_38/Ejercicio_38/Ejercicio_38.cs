using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Ejercicio_38
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 38";

            Sobreescrito sobrecarga = new Sobreescrito();
            Sobreescrito sobrecarga2 = new Sobreescrito();
            Console.WriteLine(sobrecarga.ToString());

            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas: ");
            Console.WriteLine(sobrecarga.Equals(sobrecarga2));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());


            Console.ReadKey();       
        }
    }


    public class Sobreescrito
    {
        

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Sobreescrito)
            {
                retorno = true;
            }
            return retorno;
        }


        public override int GetHashCode()
        {
            int retorno = 1142510187;
            return retorno;
        }
    }
}
