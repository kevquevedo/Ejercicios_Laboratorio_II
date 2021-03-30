using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        /// <summary>
        /// Tranforma el Número Decimal recibido por parametro a Número Binario.
        /// </summary>
        /// <param name="valorEntero">Valor entero a transformar a binario.</param>
        /// <returns>Retorna el numero binario.</returns>
        public static string DecimalBinario(int valorEntero)
        {
            String cadena;

            if (valorEntero > 0)
            {
                cadena = "";
                //Mientras el valor ingresado sea mayor a 0 (cero) voy a iterar.
                while (valorEntero > 0)
                {
                    //Si el numero es divisible por dos, concateno un "0" al principio de la cadena.
                    if(valorEntero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        //Si el numero NO es divisible por dos, concateno un "1" al principio de la cadena.
                        cadena = "1" + cadena;
                    }
                    //Divido el valor del entero ingresado por dos, y lo casteo a int (Para que me saque los decimales).
                    valorEntero = (int)(valorEntero / 2);
                }
            }
            else
            {
                //Si el valor ingresado es 0, concateno "0" a cadena.
                cadena = "0";
            }
            return cadena;
        }

        /// <summary>
        /// Tranforma el Número Binario recibido por parametro a Número Decimal.
        /// </summary>
        /// <param name="valorString">Valor entero a transformar a decimal.</param>
        /// <returns>Retorna el numero decimal.</returns>
        public static int BinarioDecimal(string valorString)
        {
            int retorno = 0;
            int potencia = valorString.Length - 1;//Inicializo la potencia con su valor maximo.

            for (int i = 0; i < valorString.Length; i++)//Recorro el array de string (Como limite su longitud).
            {
               if (int.TryParse(valorString[i].ToString(), out int conversion))//Convierto el string (Primero casteo a String), y luego a Int.
                {
                    int aux = (int)(Math.Pow(2, potencia));//Determino el valor del producto entre la potencia y la base.
                    retorno += (conversion * aux); //Multiplico el valor generado en la linea anterior, por el digito binario 1 ó 0.
                    potencia--; //Decremento la potencia.
                }
            }       
            return retorno;
        }


    }
}
