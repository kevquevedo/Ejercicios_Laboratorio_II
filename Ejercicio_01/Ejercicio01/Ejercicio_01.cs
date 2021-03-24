using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 1";

            int contador = 0;
            int numIngr;
            int numMax = 0;
            int numMin = 0;
            int acumulador = 0;
            while (contador<5)
            {
                Console.Write("Ingrese un numero: ");
                numIngr = int.Parse(Console.ReadLine());
                if(contador==0)
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
            float prom = acumulador / (float)contador;
            Console.WriteLine();
            Console.WriteLine("El numero mayor es: {0}",numMax);
            Console.WriteLine($"El numero minimo es: {numMin}");
            Console.WriteLine($"El promedio es: {prom:#.00}");
            Console.ReadKey();
        }
    }
}
