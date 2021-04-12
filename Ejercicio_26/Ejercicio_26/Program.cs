using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 26";

            int[] numeros = new int[5];
            Random random = new Random();
            int auxiliar;
            bool grabar = false;

            //Hago el array
            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    auxiliar = random.Next(-100, 100);
                    if(auxiliar != 0)
                    {
                        numeros[i] = auxiliar;
                        grabar = true;
                    }
                } while (!grabar);
                       
            }

            //imprimo por consola
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor del indice {i} es: {numeros[i]}");
            }

            //--------------------------------------------------------------------------------

            //SORT DECRECIENTE
            int auxSortDecreciente;

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        auxSortDecreciente = numeros[j + 1];
                        numeros[j + 1] = numeros[j];
                        numeros[j] = auxSortDecreciente;
                    }
                }
            }

            //IMPRIMO SORT POR PANTALLA
            Console.WriteLine("------------Decreciente-----------------");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor del indice {i} es: {numeros[i]}");
            }

            //--------------------------------------------------------------------------------
            
            //SORT CRECIENTE
            int auxSortCreciente;

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        auxSortCreciente = numeros[j + 1];
                        numeros[j + 1] = numeros[j];
                        numeros[j] = auxSortCreciente;
                    }
                }
            }

            //IMPRIMO SORT POR PANTALLA
            Console.WriteLine("------------Creciente-----------------");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor del indice {i} es: {numeros[i]}");
            }

            Console.ReadKey();
        }
    }
}
