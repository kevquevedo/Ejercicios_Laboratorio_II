using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double temperatura;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor que inicializa el atributo temperatura de Celsius.
        /// </summary>
        public Celsius()
        {
            this.temperatura = 0; 
        }

        /// <summary>
        /// Constructor que asigna el parametro cantidad a temperatura.
        /// </summary>
        public Celsius(double cantidad) : this()
        {
            this.temperatura = cantidad;
        }

        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene la cantidad de temperatura del objeto.
        /// </summary>
        /// <returns>Retorna la cantidad de pesos en tipo de dato double.</returns>
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        #endregion

        #region OPERADORES DE CONVERSION

        /// <summary>
        /// Castea un tipo de dato double a Celsius.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "temperatura" del objeto Celsius.</param>
        /// <returns>Retorna un objeto del tipo Celsius.</returns>
        public static implicit operator Celsius(double cantidad)
        {
            return new Celsius(cantidad);
        }

        /// <summary>
        /// Castea un tipo de dato Fahrenheit a Celsius.
        /// </summary>
        /// <param name="fahrenheit">Parametro del tipo Fahrenheit a castear a Celsius.</param>
        /// <returns>Retorna un objeto del tipo Celsius.</returns>
        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            double valor = (fahrenheit.GetTemperatura() - 32) * 5 / 9;
            return new Celsius(valor);
        }

        /// <summary>
        /// Castea un tipo de dato Kelvin a Celsius.
        /// </summary>
        /// <param name="kelvin">Parametro del tipo Kelvin a castear a Celsius.</param>
        /// <returns>Retorna un objeto del tipo Celsius.</returns>
        public static explicit operator Celsius(Kelvin kelvin)
        {
            return (Celsius)(Fahrenheit)kelvin;
        }

        #endregion

        #region OPERADORES DE COMPARACION

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Celsius.
        /// </summary>
        /// <param name="celsius1">Primer argumento a comparar.</param>
        /// <param name="celsius2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Celsius celsius1, Celsius celsius2)
        {
            bool retorno = false;
            if(celsius1.GetTemperatura() == celsius2.GetTemperatura())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Celsius.
        /// </summary>
        /// <param name="celsius1">Primer argumento a comparar.</param>
        /// <param name="celsius2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Celsius celsius1, Celsius celsius2)
        {
            return !(celsius1 == celsius2);
        }


        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Celsius y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="celsius">Primer argumento a comparar.</param>
        /// <param name="fahrenheit">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Celsius celsius, Fahrenheit fahrenheit)
        {
            bool retorno = false;
            Celsius aux = (Celsius)fahrenheit;
            if (celsius == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Celsius y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="celsius">Primer argumento a comparar.</param>
        /// <param name="fahrenheit">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Celsius celsius, Fahrenheit fahrenheit)
        {
            return !(celsius == fahrenheit);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Celsius y otro del tipo Kelvin.
        /// </summary>
        /// <param name="celsius">Primer argumento a comparar.</param>
        /// <param name="kelvin">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Celsius celsius, Kelvin kelvin)
        {
            bool retorno = false;
            Celsius aux = (Celsius)kelvin;
            if (celsius == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Celsius y otro del tipo Kelvin.
        /// </summary>
        /// <param name="celsius">Primer argumento a comparar.</param>
        /// <param name="kelvin">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Celsius celsius, Kelvin kelvin)
        {
            return !(celsius == kelvin);
        }

        #endregion

        #region OPERADORES DE CALCULO

        /// <summary>
        /// Suma dos argumentos del tipo Celsius.
        /// </summary>
        /// <param name="celsius1">Primer argumento a sumar.</param>
        /// <param name="celsius2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un objeto Celsius, con el valor de la suma.</returns>
        public static Celsius operator +(Celsius celsius1, Celsius celsius2)
        {
            Celsius retorno = new Celsius(celsius1.GetTemperatura() + celsius2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos del tipo Celsius.
        /// </summary>
        /// <param name="celsius1">Primer argumento a restar.</param>
        /// <param name="celsius2">Segundo argumento a restar.</param>
        /// <returns>Retorna un objeto Celsius, con el valor de la resta.</returns>
        public static Celsius operator -(Celsius celsius1, Celsius celsius2)
        {
            Celsius retorno = new Celsius(celsius1.GetTemperatura() - celsius2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Celsius y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="celsius">Primer argumento a sumar.</param>
        /// <param name="fahrenheit">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Celsius, con el valor de la suma.</returns>
        public static Celsius operator +(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius aux = (Celsius)fahrenheit;
            return celsius + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Celsius y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="celsius">Primer argumento a restar.</param>
        /// <param name="fahrenheit">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Celsius, con el valor de la resta.</returns>
        public static Celsius operator -(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius aux = (Celsius)fahrenheit;
            return celsius - aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Celsius y otro del tipo Kelvin.
        /// </summary>
        /// <param name="celsius">Primer argumento a sumar.</param>
        /// <param name="kelvin">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Celsius, con el valor de la suma.</returns>
        public static Celsius operator +(Celsius celsius, Kelvin kelvin)
        {
            Celsius aux = (Celsius)kelvin;
            return celsius + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Celsius y otro del tipo Kelvin.
        /// </summary>
        /// <param name="celsius">Primer argumento a restar.</param>
        /// <param name="kelvin">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Celsius, con el valor de la resta.</returns>
        public static Celsius operator -(Celsius celsius, Kelvin kelvin)
        {
            Celsius aux = (Celsius)kelvin;
            return celsius - aux;
        }

        #endregion

    }
}
