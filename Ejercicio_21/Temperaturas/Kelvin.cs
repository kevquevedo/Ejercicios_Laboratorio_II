using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double temperatura;

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor que inicializa el atributo temperatura de Kelvin.
        /// </summary>
        public Kelvin()
        {
            this.temperatura = 0;
        }

        /// <summary>
        /// Constructor que asigna el parametro cantidad a temperatura.
        /// </summary>
        public Kelvin(double cantidad) : this()
        {
            this.temperatura = cantidad;
        }

        #endregion

        #region GETTER

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
        /// Castea un tipo de dato double a Kelvin.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "temperatura" del objeto Kelvin.</param>
        /// <returns>Retorna un objeto del tipo Kelvin.</returns>
        public static implicit operator Kelvin(double cantidad)
        {
            return new Kelvin(cantidad);
        }

        /// <summary>
        /// Castea un tipo de dato Fahrenheit a Kelvin.
        /// </summary>
        /// <param name="fahrenheit">Parametro del tipo Fahrenheit a castear a Kelvin.</param>
        /// <returns>Retorna un objeto del tipo Kelvin.</returns>
        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            double valor = (fahrenheit.GetTemperatura() + 459.67) * 5 / 9;
            return new Kelvin(valor);
        }

        /// <summary>
        /// Castea un tipo de dato Celsius a Kelvin.
        /// </summary>
        /// <param name="celsius">Parametro del tipo Celsius a castear a Kelvin.</param>
        /// <returns>Retorna un objeto del tipo Kelvin.</returns>
        public static explicit operator Kelvin(Celsius celsius)
        {
            return (Kelvin)(Fahrenheit)celsius;
        }

        #endregion

        #region OPERADORES DE COMPARACION

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Kelvin.
        /// </summary>
        /// <param name="kelvin1">Primer argumento a comparar.</param>
        /// <param name="kelvin2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Kelvin kelvin1, Kelvin kelvin2)
        {
            bool retorno = false;
            if (kelvin1.GetTemperatura() == kelvin2.GetTemperatura())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Kelvin.
        /// </summary>
        /// <param name="kelvin1">Primer argumento a comparar.</param>
        /// <param name="kelvin2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Kelvin kelvin1, Kelvin kelvin2)
        {
            return !(kelvin1 == kelvin2);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Kelvin y otro del tipo Celsius.
        /// </summary>
        /// <param name="kelvin">Primer argumento a comparar.</param>
        /// <param name="celsius">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Kelvin kelvin, Celsius celsius)
        {
            bool retorno = false;
            Kelvin aux = (Kelvin)celsius;
            if (kelvin == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Kelvin y otro del tipo Celsius.
        /// </summary>
        /// <param name="kelvin">Primer argumento a comparar.</param>
        /// <param name="celsius">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Kelvin kelvin, Celsius celsius)
        {
            return !(kelvin == celsius);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Kelvin y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="kelvin">Primer argumento a comparar.</param>
        /// <param name="fahrenheit">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            bool retorno = false;
            Kelvin aux = (Kelvin)fahrenheit;
            if (kelvin == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Kelvin y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="kelvin">Primer argumento a comparar.</param>
        /// <param name="fahrenheit">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            return !(kelvin == fahrenheit);
        }

        #endregion

        #region OPERADORES DE CALCULO

        /// <summary>
        /// Suma dos argumentos del tipo Kelvin.
        /// </summary>
        /// <param name="kelvin1">Primer argumento a sumar.</param>
        /// <param name="kelvin2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un objeto Kelvin, con el valor de la suma.</returns>
        public static Kelvin operator +(Kelvin kelvin1, Kelvin kelvin2)
        {
            Kelvin retorno = (Kelvin)(kelvin1.GetTemperatura() + kelvin2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos del tipo Kelvin.
        /// </summary>
        /// <param name="kelvin1">Primer argumento a restar.</param>
        /// <param name="kelvin2">Segundo argumento a restar.</param>
        /// <returns>Retorna un objeto Kelvin, con el valor de la resta.</returns>
        public static Kelvin operator -(Kelvin kelvin1, Kelvin kelvin2)
        {
            Kelvin retorno = (Kelvin)(kelvin1.GetTemperatura() - kelvin2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Kelvin y otro del tipo Celsius.
        /// </summary>
        /// <param name="kelvin">Primer argumento a sumar.</param>
        /// <param name="celsius">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Kelvin, con el valor de la suma.</returns>
        public static Kelvin operator +(Kelvin kelvin, Celsius celsius)
        {
            Kelvin aux = (Kelvin)celsius;
            return kelvin + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Kelvin y otro del tipo Celsius.
        /// </summary>
        /// <param name="kelvin">Primer argumento a restar.</param>
        /// <param name="celsius">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Kelvin, con el valor de la resta.</returns>
        public static Kelvin operator -(Kelvin kelvin, Celsius celsius)
        {
            Kelvin aux = (Kelvin)celsius;
            return kelvin - aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Kelvin y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="kelvin">Primer argumento a sumar.</param>
        /// <param name="fahrenheit">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Kelvin, con el valor de la suma.</returns>
        public static Kelvin operator +(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin aux = (Kelvin)fahrenheit;
            return kelvin + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Kelvin y otro del tipo Fahrenheit.
        /// </summary>
        /// <param name="kelvin">Primer argumento a restar.</param>
        /// <param name="fahrenheit">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Kelvin, con el valor de la resta.</returns>
        public static Kelvin operator -(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin aux = (Kelvin)fahrenheit;
            return kelvin - aux;
        }

        #endregion
    }
}
