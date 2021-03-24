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
            int i;
            int limit = 0;
            int num = 1;
            int acumulador = 0;

            while(limit < 4)
            {
                //tiene que ser divisor, es decir, % ==0
                //tiene que haber un acumulador, para ser igualado
                //tengo que incrementar si encontre un perfecto
                num++;
                for (int j = 1; j < num; j++)
                {
                    for (i = 1; i < j; i++)
                    {
                        if (j % i == 0)
                        {
                            acumulador += i;
                        }
                    }
                    if (acumulador == j && j != 1)
                    {
                        Console.WriteLine($"{j} es un numero Perfecto.");
                        limit++;
                        break;
                    }
                    acumulador = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
