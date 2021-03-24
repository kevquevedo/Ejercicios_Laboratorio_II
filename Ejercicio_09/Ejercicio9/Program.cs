using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string signo = "*";
            Console.Write("Ingrese la altura: ");
            int numIngresado = int.Parse(Console.ReadLine());

            Piramide(signo,numIngresado);
        }

        static string Piramide(string simbolo,int altura)
        {
            string aux = simbolo;
            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(aux);
                }
                else
                {
                    Console.WriteLine(aux);
                }
                aux = aux + simbolo + simbolo;
            }
            Console.ReadKey();
            return simbolo.ToString();
        }
    }
}
