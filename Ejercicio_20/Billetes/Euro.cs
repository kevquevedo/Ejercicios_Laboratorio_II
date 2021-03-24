using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor privado que inicializa la cotizacion del Euro.
        /// </summary>
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad el valor brindado como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad y cotizacion los valores brindados como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        /// <param name="cotizacion">Cotizacion del Peso a asignar al objeto.</param>
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene la cotizacion de la moneda Euro del objeto.
        /// </summary>
        /// <returns>Retorna la cotizacion del Euro en tipo de dato double.</returns>
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        /// <summary>
        /// Obtiene la cantidad de Euros del objeto.
        /// </summary>
        /// <returns>Retorna la cantidad de euros en tipo de dato double.</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region OPERADORES DE CONVERSION

        /// <summary>
        /// Castea un tipo de dato double a Euro.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "cantidad" del objeto Euro.</param>
        /// <returns>Retorna un objeto del tipo Euro.</returns>
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        /// <summary>
        /// Castea un tipo de dato Dolar a Euro.
        /// </summary>
        /// <param name="dolar">Parametro del tipo Dolar a castear.</param>
        /// <returns>Retorna un objeto del tipo Euro.</returns>
        public static explicit operator Euro(Dolar dolar)
        {
            double valor = dolar.GetCantidad() / Euro.GetCotizacion();  
            return new Euro(valor);
        }

        /// <summary>
        /// Castea un tipo de dato Pesos a Euro.
        /// </summary>
        /// <param name="peso">Parametro del tipo Pesos a castear.</param>
        /// <returns>Retorna un objeto del tipo Euro.</returns>
        public static explicit operator Euro(Pesos peso)
        {
            return (Euro)(Dolar)peso;
        }
        #endregion

        #region OPERADORES DE CALCULO

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Euro.
        /// </summary>
        /// <param name="euro1">Primer argumento a comparar.</param>
        /// <param name="euro2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Euro euro1, Euro euro2)
        {
            bool retorno = false;
            if (euro1.cantidad == euro2.cantidad) //Comparo el valor del atributo cantidad.
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Euro.
        /// </summary>
        /// <param name="euro1">Primer argumento a comparar.</param>
        /// <param name="euro2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1==euro2); //Reutilizo codigo para validacion e invierto el valor con !();
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Euro y otro del tipo Dolar.
        /// </summary>
        /// <param name="euro">Primer argumento a comparar.</param>
        /// <param name="dolar">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Euro euro, Dolar dolar)
        {
            bool retorno = false;
            Euro aux = (Euro)dolar;
            if (euro.cantidad == aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Euro y otro del tipo Dolar.
        /// </summary>
        /// <param name="euro">Primer argumento a comparar.</param>
        /// <param name="dolar">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Euro y otro del tipo Pesos.
        /// </summary>
        /// <param name="euro">Primer argumento a comparar.</param>
        /// <param name="peso">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Euro euro, Pesos peso)
        {
            bool retorno = false;
            Euro aux = (Euro)peso;
            if (euro.cantidad == aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Euro y otro del tipo Pesos.
        /// </summary>
        /// <param name="euro">Primer argumento a comparar.</param>
        /// <param name="peso">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Euro euro, Pesos peso)
        {
            return !(euro == peso);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Euro.
        /// </summary>
        /// <param name="euro1">Primer argumento a sumar.</param>
        /// <param name="euro2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la suma.</returns>
        public static Euro operator +(Euro euro1, Euro euro2)
        {
            return new Euro(euro1.cantidad + euro2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Euro.
        /// </summary>
        /// <param name="euro1">Primer argumento a restar.</param>
        /// <param name="euro2">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la resta.</returns>
        public static Euro operator -(Euro euro1, Euro euro2)
        {
            return new Euro(euro1.cantidad - euro2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Euro y otro del tipo Dolar.
        /// </summary>
        /// <param name="euro">Primer argumento a sumar.</param>
        /// <param name="dolar">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la suma.</returns>
        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro aux = (Euro)dolar;
            return new Euro(euro.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Euro y otro del tipo Dolar.
        /// </summary>
        /// <param name="euro">Primer argumento a restar.</param>
        /// <param name="dolar">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la resta.</returns>
        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro aux = (Euro)dolar;
            return new Euro(euro.cantidad - aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Euro y otro del tipo Pesos.
        /// </summary>
        /// <param name="euro">Primer argumento a sumar.</param>
        /// <param name="peso">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la suma.</returns>
        public static Euro operator +(Euro euro, Pesos peso)
        {
            Euro aux = (Euro)peso;
            return new Euro(euro.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Euro y otro del tipo Pesos.
        /// </summary>
        /// <param name="euro">Primer argumento a restar.</param>
        /// <param name="peso">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Euro, con el valor de la resta.</returns>
        public static Euro operator -(Euro euro, Pesos peso)
        {
            Euro aux = (Euro)peso;
            return new Euro(euro.cantidad - aux.cantidad);
        }

        #endregion
    }
}
