using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double temperatura;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor que inicializa el atributo temperatura de Fahrenheit.
        /// </summary>
        public Fahrenheit()
        {
            this.temperatura = 0;
        }

        /// <summary>
        /// Constructor que asigna el parametro cantidad a temperatura.
        /// </summary>
        public Fahrenheit(double cantidad) : this()
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
        /// Castea un tipo de dato double a Fahrenheit.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "temperatura" del objeto Fahrenheit.</param>
        /// <returns>Retorna un objeto del tipo Fahrenheit.</returns>
        public static implicit operator Fahrenheit(double cantidad)
        {
            return new Fahrenheit(cantidad);
        }

        /// <summary>
        /// Castea un tipo de dato Celsius a Fahrenheit.
        /// </summary>
        /// <param name="celsius">Parametro del tipo Celsius a castear a Fahrenheit.</param>
        /// <returns>Retorna un objeto del tipo Fahrenheit.</returns>
        public static explicit operator Fahrenheit(Celsius celsius)
        {
            double valor = (celsius.GetTemperatura() * 9 / 5) + 32;
            return new Fahrenheit(valor);   
        }

        /// <summary>
        /// Castea un tipo de dato Kelvin a Fahrenheit.
        /// </summary>
        /// <param name="kelvin">Parametro del tipo Kelvin a castear a Fahrenheit.</param>
        /// <returns>Retorna un objeto del tipo Fahrenheit.</returns>
        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            double valor = (kelvin.GetTemperatura() * 9 / 5) - 459.67;
            return new Fahrenheit(valor);
        }

        #endregion

        #region OPERADORES DE COMPARACION

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Fahrenheit.
        /// </summary>
        /// <param name="fahrenheit1">Primer argumento a comparar.</param>
        /// <param name="fahrenheit2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            bool retorno = false;
            if (fahrenheit1.GetTemperatura() == fahrenheit2.GetTemperatura())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Fahrenheit.
        /// </summary>
        /// <param name="fahrenheit1">Primer argumento a comparar.</param>
        /// <param name="fahrenheit2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            return !(fahrenheit1 == fahrenheit2);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Fahrenheit y otro del tipo Celsius.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a comparar.</param>
        /// <param name="celsius">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Fahrenheit fahrenheit, Celsius celsius)
        {
            bool retorno = false;
            Fahrenheit aux = (Fahrenheit)celsius;
            if (fahrenheit == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Fahrenheit y otro del tipo Celsius.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a comparar.</param>
        /// <param name="celsius">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Fahrenheit fahrenheit, Celsius celsius)
        {
            return !(fahrenheit == celsius);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Fahrenheit y otro del tipo Kelvin.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a comparar.</param>
        /// <param name="kelvin">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son IGUALES.</returns>
        public static bool operator ==(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            bool retorno = false;
            Fahrenheit aux = (Fahrenheit)kelvin;
            if (fahrenheit == aux)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Fahrenheit y otro del tipo Kelvin.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a comparar.</param>
        /// <param name="kelvin">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return !(fahrenheit == kelvin);
        }

        #endregion

        #region OPERADORES DE CALCULO

        /// <summary>
        /// Suma dos argumentos del tipo Fahrenheit.
        /// </summary>
        /// <param name="fahrenheit1">Primer argumento a sumar.</param>
        /// <param name="fahrenheit2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un objeto Fahrenheit, con el valor de la suma.</returns>
        public static Fahrenheit operator +(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            Fahrenheit retorno = (Fahrenheit)(fahrenheit1.GetTemperatura() + fahrenheit2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos del tipo Fahrenheit.
        /// </summary>
        /// <param name="fahrenheit1">Primer argumento a restar.</param>
        /// <param name="fahrenheit2">Segundo argumento a restar.</param>
        /// <returns>Retorna un objeto Fahrenheit, con el valor de la resta.</returns>
        public static Fahrenheit operator -(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            Fahrenheit retorno = (Fahrenheit)(fahrenheit1.GetTemperatura() - fahrenheit2.GetTemperatura());
            return retorno;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Fahrenheit y otro del tipo Kelvin.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a sumar.</param>
        /// <param name="kelvin">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Fahrenheit, con el valor de la suma.</returns>
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit aux = (Fahrenheit)kelvin;
            return fahrenheit + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Fahrenheit y otro del tipo Kelvin.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a restar.</param>
        /// <param name="kelvin">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Fahrenheit, con el valor de la resta.</returns>
        public static Fahrenheit operator -(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit aux = (Fahrenheit)kelvin;
            return fahrenheit - aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Fahrenheit y otro del tipo Celsius.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a sumar.</param>
        /// <param name="celsius">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Fahrenheit, con el valor de la suma.</returns>
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit aux = (Fahrenheit)celsius;
            return fahrenheit + aux;
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Fahrenheit y otro del tipo Celsius.
        /// </summary>
        /// <param name="fahrenheit">Primer argumento a restar.</param>
        /// <param name="celsius">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Fahrenheit, con el valor de la resta.</returns>
        public static Fahrenheit operator -(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit aux = (Fahrenheit)celsius;
            return fahrenheit - aux;
        }

        #endregion
    }
}
