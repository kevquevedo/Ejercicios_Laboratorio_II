using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Ejercicio_27
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 27";
            /*
              
            
            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////
            //                               LIST/LISTA RANDOM
            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////
             
            List<int> numeros = new List<int>();
            Random numRandom = new Random();
            int auxiliar;

            
            Console.WriteLine("------------LISTA ORIGINAL------------------------");
            
            //Creo la lista random, con numeros entre -100 y 100, exceptuando el 0.
            for (int i = 0; i < 5; i++)
            {
                auxiliar = numRandom.Next(-100, 100);
                if (auxiliar != 0)
                {
                    numeros.Add(auxiliar);
                }
            }

            //Recorro la Lista y la imprimo.
            foreach (int item in numeros)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------LISTA CRECIENTE----------------------------");

            //Realizo el Sort, que por defecto es CRECIENTE.
            numeros.Sort();

            //Recorro la Lista y la imprimo.
            foreach (int item in numeros)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------LISTA DECRECIENTE----------------------------");

            //Hago una funcion que me permita ingresarla al Sort y ordenarla segun criterio que elija.
            /// Si "num2" es mayor a "num1", devuelve un número positivo.
            /// Si "num2" es menor a "num1", devuelve un número negativo.
            /// Si "num2" es igual a "num1", devuelve cero.
            int Comparar(int num1, int num2)
            {
                return num2 - num1;
            }

            //Realizo el Sort
            numeros.Sort(Comparar);//Uso la funcion que cree anteriormente

            //Recorro la Lista y la imprimo.
            foreach (int item in numeros)
            {
                Console.WriteLine($"El numero es: {item}");
            }*/


            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////
            //                               STACK/PILA RANDOM
            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////

            /*
            Console.WriteLine("------------PILA ORIGINAL------------------------");

            Stack<int> numerosPila = new Stack<int>();
            Random numRandom2 = new Random();
            int auxiliar2;

            for (int i = 0; i < 5; i++)
            {
                auxiliar2 = numRandom2.Next(-100, 100);
                if(auxiliar2 != 0)
                {
                    numerosPila.Push(auxiliar2);
                }
            }

            foreach (int item in numerosPila)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------PILA CRECIENTE------------------------");

            List<int> pilaAuxList = new List<int>(numerosPila.ToList());//Casteo la PILA/STACK A LIST.
            pilaAuxList.Sort();

            //Recorro la Lista y la imprimo.
            foreach (int item in pilaAuxList)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------PILA DECRECIENTE------------------------");

            //Hago una funcion que me permita ingresarla al Sort y ordenarla segun criterio que elija.
            /// Si "num2" es mayor a "num1", devuelve un número positivo.
            /// Si "num2" es menor a "num1", devuelve un número negativo.
            /// Si "num2" es igual a "num1", devuelve cero.
            int Decreciente(int num1, int num2)
            {
                return num2 - num1;
            }

            pilaAuxList.Sort(Decreciente);

            //Recorro la Lista y la imprimo.
            foreach (int item in pilaAuxList)
            {
                Console.WriteLine($"El numero es: {item}");
            }
            */

            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////
            //                      QUEUE/COLA RANDOM
            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("------------COLA ORIGINAL------------------------");

            Queue<int> numeros = new Queue<int>();
            Random numRandom = new Random();
            int auxiliar;

            for (int i = 0; i < 5; i++)
            {
                auxiliar = numRandom.Next(-100, 100);
                if (auxiliar != 0)
                {
                    numeros.Enqueue(auxiliar);
                }
            }

            foreach (int item in numeros)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------COLA CRECIENTE------------------------");

            List<int> colaAuxList = new List<int>(numeros.ToList());
            colaAuxList.Sort();

            foreach (int item in colaAuxList)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.WriteLine("------------COLA DECRECIENTE------------------------");

            int Decreciente(int num1, int num2)
            {
                return num2 - num1;
            }

            colaAuxList.Sort(Decreciente);

            foreach (int item in colaAuxList)
            {
                Console.WriteLine($"El numero es: {item}");
            }

            Console.ReadKey();
        }
    }
}
