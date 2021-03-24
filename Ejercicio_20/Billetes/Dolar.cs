using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor privado que inicializa la cotizacion del Euro.
        /// </summary>
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad el valor brindado como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad y cotizacion los valores brindados como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        /// <param name="cotizacion">Cotizacion del Peso a asignar al objeto.</param>
        public Dolar(double cantidad, double cotizacion) : this (cantidad)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene la cotizacion de la moneda Dolar del objeto.
        /// </summary>
        /// <returns>Retorna la cotizacion del Dolar en tipo de dato double.</returns>
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        /// <summary>
        /// Obtiene la cantidad de Dolares del objeto.
        /// </summary>
        /// <returns>Retorna la cantidad de dolares en tipo de dato double.</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region OPERADORES DE CONVERSION

        /// <summary>
        /// Castea un tipo de dato double a Dolar.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "cantidad" del objeto Dolar.</param>
        /// <returns>Retorna un objeto del tipo Dolar.</returns>
        public static implicit operator Dolar(double cantidad)
        {
            Dolar retorno = new Dolar(cantidad);
            return retorno;
        }

        /// <summary>
        /// Castea un tipo de dato Pesos a Dolar.
        /// </summary>
        /// <param name="peso">Parametro del tipo Pesos a castear.</param>
        /// <returns>Retorna un objeto del tipo Dolar.</returns>
        public static explicit operator Dolar(Pesos peso)
        {
            double valor = peso.GetCantidad() / Pesos.GetCotizacion();
            return new Dolar(valor);
        }

        /// <summary>
        /// Castea un tipo de dato Euro a Dolar.
        /// </summary>
        /// <param name="euro">Parametro del tipo Euro a castear.</param>
        /// <returns>Retorna un objeto del tipo Dolar.</returns>
        public static explicit operator Dolar(Euro euro)
        {
            double valor = euro.GetCantidad() * Euro.GetCotizacion();
            return new Dolar(valor);
        }


        #endregion

        #region OPERADORES DE CALCULO

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Dolar.
        /// </summary>
        /// <param name="dolar1">Primer argumento a comparar.</param>
        /// <param name="dolar2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            bool retorno = false;
            if (dolar1.cantidad == dolar2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Dolar.
        /// </summary>
        /// <param name="dolar1">Primer argumento a comparar.</param>
        /// <param name="dolar2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1==dolar2);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Dolar y otro del tipo Pesos.
        /// </summary>
        /// <param name="dolar">Primer argumento a comparar.</param>
        /// <param name="peso">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Dolar dolar, Pesos peso)
        {
            bool retorno = false;
            Dolar aux = (Dolar)peso;
            if (dolar.cantidad==aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Dolar y otro del tipo Pesos.
        /// </summary>
        /// <param name="dolar">Primer argumento a comparar.</param>
        /// <param name="peso">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Dolar dolar, Pesos peso)
        {
            return !(dolar == peso);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Dolar y otro del tipo Euro.
        /// </summary>
        /// <param name="dolar">Primer argumento a comparar.</param>
        /// <param name="euro">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Dolar dolar, Euro euro)
        {
            bool retorno = false;
            Dolar aux = (Dolar)euro;
            if(dolar.cantidad == aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Dolar y otro del tipo Euro.
        /// </summary>
        /// <param name="dolar">Primer argumento a comparar.</param>
        /// <param name="euro">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Dolar.
        /// </summary>
        /// <param name="dolar1">Primer argumento a sumar.</param>
        /// <param name="dolar2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la suma.</returns>
        public static Dolar operator +(Dolar dolar1, Dolar dolar2)
        {
            return new Dolar(dolar1.cantidad + dolar2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Dolar.
        /// </summary>
        /// <param name="dolar1">Primer argumento a restar.</param>
        /// <param name="dolar2">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la resta.</returns>
        public static Dolar operator -(Dolar dolar1, Dolar dolar2)
        {
            return new Dolar(dolar1.cantidad - dolar2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Dolar y otro del tipo Pesos.
        /// </summary>
        /// <param name="dolar">Primer argumento a sumar.</param>
        /// <param name="peso">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la suma.</returns>
        public static Dolar operator +(Dolar dolar, Pesos peso)
        {
            Dolar aux = (Dolar)peso;
            return new Dolar(dolar.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Dolar y otro del tipo Pesos.
        /// </summary>
        /// <param name="dolar">Primer argumento a restar.</param>
        /// <param name="peso">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la resta.</returns>
        public static Dolar operator -(Dolar dolar, Pesos peso)
        {
            Dolar aux = (Dolar)peso;
            return new Dolar(dolar.cantidad - aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Dolar y otro del tipo Euro.
        /// </summary>
        /// <param name="dolar">Primer argumento a sumar.</param>
        /// <param name="euro">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la suma.</returns>
        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar aux = (Dolar)euro;
            return new Dolar(dolar.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Dolar y otro del tipo Euro.
        /// </summary>
        /// <param name="dolar">Primer argumento a restar.</param>
        /// <param name="euro">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Dolar, con el valor de la resta.</returns>
        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar aux = (Dolar)euro;
            return new Dolar(dolar.cantidad - aux.cantidad);
        }

        #endregion
    }
}