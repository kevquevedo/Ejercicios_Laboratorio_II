using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza una operación entre dos numeros.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operacion.</param>
        /// <param name="num2">Segundo numero para realizar la operacion.</param>
        /// <param name="operador">Operacion a realizar.</param>
        /// <returns>Retorna el valor de la operación realizada.</returns>
        public static double Calcular(double num1, double num2, string operador)
        {
            double resultado = 0;

            switch (operador)//Switch para determinar la operacion a realizar.
            {
                case "+"://Si la variable "operador" es +, realiza la suma.
                    {
                        resultado = num1 + num2;
                        break;
                    }
                case "-"://Si la variable "operador" es -, realiza la resta.
                    {
                        resultado = num1 - num2;
                        break;
                    }
                case "*"://Si la variable "operador" es *, realiza la multiplicación.
                    {
                        resultado = num1 * num2;
                        break;
                    }
                case "/"://Si la variable "operador" es /, realiza la división.
                    {
                        if (Validar(num2))//Valida que el segundo numero, sea distinto de 0 (cero).
                        {
                            resultado = num1 / num2;
                        }                        
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el numero recibido como parametro sea distinto de 0 (Cero).
        /// </summary>
        /// <param name="numero">Número recibido a evaluar.</param>
        /// <returns>Retorna TRUE, si el valor recibido es distinto de 0 (Cero).</returns>
        private static bool Validar(double numero)
        {
            bool retorno = true;
            if(numero == 0)
            {
                retorno = false;
            }
            return retorno;
        }
    }

    public class ValidarRespuesta
    {
        /// <summary>
        /// Valida que el caracter recibido sea S/s (Sí). Se utiliza como validar de respuesta.
        /// </summary>
        /// <param name="caracter">Caracter recibido a evaluar.</param>
        /// <returns>Retorna TRUE, si el caracter recibido es una S ó s.</returns>
        public static bool ValidaS_N(char caracter)
        {
            bool retorno = false;
            if (caracter == 'S' || caracter == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
