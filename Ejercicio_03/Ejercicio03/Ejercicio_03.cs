using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 3";

            Console.Write("Por favor, ingrese un numero: ");
            int numIngr = int.Parse(Console.ReadLine());
            int i;
            int j;

            //Si el numero es mayor a cero, ya imprimo el 1 como primo.
            if(numIngr > 0)
            {
                Console.Write("Los numeros primos son: 1");
            }
            //Recorro y evaluo todos los numeros hasta el numero ingresado (numIngr).
            for (i=2; i < numIngr; i++)
            {
                //Evaluo numero por numero hasta -1 del numero ingresado (numIngr).
                for (j=2; j < i; j++)
                {
                    //Si el numero (i) es divisible por el seg num (j) termino de recorrer.
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                //Si el seg num (j), es igual al primero (i) lo imprimo, sino no es primo.
                if (i == j)
                {
                    Console.Write(", " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
