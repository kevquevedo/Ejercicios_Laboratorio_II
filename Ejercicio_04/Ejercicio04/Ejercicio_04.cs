using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 4";
            int limit = 0;
            int num = 1;
            int acumulador;

            while(limit < 4)
            {
                acumulador = 0;
                //Busco los divisores del numero actual. Desde al "numero" a 0 (Cero).
                for (int i = num - 1; i > 0; i--)
                {
                    if(num % i == 0)//Si el numero que recorro es divisible por "i" lo acumulo.
                    {
                        acumulador += i;
                        if (acumulador > num)//si el acumulado es mayor al numero que busco, rompo el for.
                        {
                            break;
                        }    
                    }
                }
                //Si el acumulador es igual al numero buscado, entonces es PERFECTO.   
                if (acumulador == num)
                {
                    Console.WriteLine($"{num} es un numero Perfecto.");
                    limit++;
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
