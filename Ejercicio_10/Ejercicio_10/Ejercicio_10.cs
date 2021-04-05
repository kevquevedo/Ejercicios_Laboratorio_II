using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            string signo = "*";
            Console.Write("Ingrese la altura: ");
            int numIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(Piramide(signo, numIngresado));
            Console.ReadKey();
        }

        static string Piramide(string simbolo, int altura)
        {
            StringBuilder sb = new StringBuilder();
            //Genero la variable que va a determinar la cantida de espacios.
            int cantEspacios = altura;
            //Concateno la cantidad de espacios.
            string spaces = String.Concat(Enumerable.Repeat(" ", cantEspacios));
            string aux = simbolo;
            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    sb.AppendLine(spaces + aux);//Concateno el espacio con la cantidad de *.
                    cantEspacios--;//Fuerzo el decremento por unica vez.
                }
                else
                {
                    sb.AppendLine(spaces + aux);//Concateno el espacio con la cantidad de *.
                }
                aux = aux + simbolo + simbolo;//Concateno a aux, otros dos simbolos mas (**), en cada iteracion.
                //Modifico la cantidad de espacio, en cada iteracion.
                spaces = String.Concat(Enumerable.Repeat(" ", cantEspacios--));
            }        
            return sb.ToString();
        }
    }
}
