using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir un string y contar cuantas letras tiene
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            char letra = 'a';
            int cantidad = ContarLetras2(palabra, letra);

            Console.Write("La cantidad de letras es: {0}",cantidad);
            Console.ReadKey();
        }

        public static int ContarLetras(string texto, char letra)
        {
            int retorno = 0;
            for (int i = 0; i < texto.Length ; i++)
            {
                if(texto.ToCharArray()[i] == letra)
                {
                    retorno++;
                }
            }
            return retorno;
        }

        public static int ContarLetras2(string texto, char letra)
        {
            int retorno = 0;

            //var item que retorna
            //collection: en este caso voy a leer un array
            foreach (char item in texto.ToCharArray())
            {
                if(Char.ToUpper(item) == Char.ToUpper(letra))
                {
                    retorno++;
                }
            }
            return retorno;
        }

        //Devuelve la parte decimal de un numero flotante.
        public static float QuitarParteEntera(float numero)
        {
            //Castea a Entero
            int numAux = (int)numero;
            //Retorno la parte decimal
            float retorno = numero - (float)numAux;
            return retorno;
        }

        /*
        Console.Write("Ingrese un numero: ");
        string dato = Console.ReadLine();

         float valorFloat = float.Parse(dato);

        QuitarParteEntera(valorFloat);

        Console.Write(QuitarParteEntera(valorFloat));

        Console.ReadKey();
        */

        /*
        int valorEntero = 25;
        string numeroString = Console.ReadLine();

        // Parseo
        int suma = valorEntero + int.Parse(numeroString);
        Console.WriteLine(suma);

        // Casteo Explicito
        float valorDecimal = 72.6f;
        suma = (int)valorDecimal;
        Console.WriteLine(suma);

        // Casteo Implicito

        int numAux = 15;
        float numeroDec = numAux;
        Console.WriteLine(numeroDec);



        Console.ReadKey();*/
    }
}
