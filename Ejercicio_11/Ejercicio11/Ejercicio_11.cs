using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 11";

            int contador = 0;
            int numIngr;
            int numMin = 0;
            int numMax = 0;
            int acumulador = 0;
            int valorMaximo = 100;
            int valorMinimo = -100;
            Console.WriteLine("Por favor, ingrese 10 numeros: ");
            while (contador < 5)
            {
                numIngr = int.Parse(Console.ReadLine());
                //if()
                if (contador == 0)
                {
                    numMax = numIngr;
                    numMin = numIngr;
                }
                else
                {
                    if (numIngr > numMax)
                    {
                        numMax = numIngr;
                    }
                    else if (numIngr < numMin)
                    {
                        numMin = numIngr;
                    }
                }
                acumulador += numIngr;
                contador++;
            }

            Console.ReadKey();
        }
    }
}
