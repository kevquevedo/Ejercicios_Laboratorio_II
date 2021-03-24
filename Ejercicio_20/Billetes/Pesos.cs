using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor privado que inicializa la cotizacion del Peso.
        /// </summary>
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66.00;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad el valor brindado como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor que asigna al atributo cantidad y cotizacion los valores brindados como argumento.
        /// </summary>
        /// <param name="cantidad">Cantidad de pesos a asignar al objeto.</param>
        /// <param name="cotizacion">Cotizacion del Peso a asignar al objeto.</param>
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene la cotizacion de la moneda Pesos del objeto.
        /// </summary>
        /// <returns>Retorna la cotizacion del Peso en tipo de dato double.</returns>
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        
        /// <summary>
        /// Obtiene la cantidad de Pesos del objeto.
        /// </summary>
        /// <returns>Retorna la cantidad de pesos en tipo de dato double.</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region OPERADORES DE CONVERSION

        /// <summary>
        /// Castea un tipo de dato double a Pesos.
        /// </summary>
        /// <param name="cantidad">Valor a asignar al atributo "cantidad" del objeto Pesos.</param>
        /// <returns>Retorna un objeto del tipo Pesos.</returns>
        public static implicit operator Pesos(double cantidad)
        {
            Pesos auxiliar = new Pesos(cantidad);
            return auxiliar;
        }

        /// <summary>
        /// Castea un tipo de dato Dolar a Pesos.
        /// </summary>
        /// <param name="dolar">Parametro del tipo Dolar a castear.</param>
        /// <returns>Retorna un objeto del tipo Pesos.</returns>
        public static explicit operator Pesos(Dolar dolar)
        {
            double valor = Pesos.cotizRespectoDolar * dolar.GetCantidad();
            return new Pesos(valor);
        }

        /// <summary>
        /// Castea un tipo de dato Euro a Pesos.
        /// </summary>
        /// <param name="euro">Parametro del tipo Euro a castear.</param>
        /// <returns>Retorna un objeto del tipo Pesos.</returns>
        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)(Dolar)euro;
        }
        #endregion

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Pesos.
        /// </summary>
        /// <param name="peso1">Primer argumento a comparar.</param>
        /// <param name="peso2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Pesos peso1, Pesos peso2)
        {
            bool retorno = false;
            if(peso1.cantidad == peso2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Pesos.
        /// </summary>
        /// <param name="peso1">Primer argumento a comparar.</param>
        /// <param name="peso2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Pesos peso1, Pesos peso2)
        {
            return !(peso1==peso2);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Pesos y otro del tipo Dolar.
        /// </summary>
        /// <param name="peso">Primer argumento a comparar.</param>
        /// <param name="dolar">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Pesos peso, Dolar dolar)
        {
            bool retorno = false;
            Pesos aux = (Pesos)dolar;
            if (peso.cantidad==aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Pesos y otro del tipo Dolar.
        /// </summary>
        /// <param name="peso">Primer argumento a comparar.</param>
        /// <param name="dolar">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Pesos peso, Dolar dolar)
        {
            return !(peso==dolar);
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Pesos y otro del tipo Euro.
        /// </summary>
        /// <param name="peso">Primer argumento a comparar.</param>
        /// <param name="euro">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son iguales.</returns>
        public static bool operator ==(Pesos peso, Euro euro)
        {
            bool retorno = false;
            Pesos aux = (Pesos)euro;
            if (peso.cantidad == aux.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre un argumento del tipo Pesos y otro del tipo Euro.
        /// </summary>
        /// <param name="pesos">Primer argumento a comparar.</param>
        /// <param name="euro">Segundo argumento a comparar.</param>
        /// <returns>Devuelve true si los argumentos son distintos.</returns>
        public static bool operator !=(Pesos pesos, Euro euro)
        {
            return !(pesos==euro);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Pesos.
        /// </summary>
        /// <param name="peso1">Primer argumento a sumar.</param>
        /// <param name="peso2">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la suma.</returns>
        public static Pesos operator +(Pesos peso1, Pesos peso2)
        {
            return new Pesos(peso1.cantidad + peso2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos del tipo Pesos.
        /// </summary>
        /// <param name="peso1">Primer argumento a restar.</param>
        /// <param name="peso2">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la resta.</returns>
        public static Pesos operator -(Pesos peso1, Pesos peso2)
        {
            return new Pesos(peso1.cantidad - peso2.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Pesos y otro del tipo Dolar.
        /// </summary>
        /// <param name="peso">Primer argumento a sumar.</param>
        /// <param name="dolar">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la suma.</returns>
        public static Pesos operator +(Pesos peso, Dolar dolar)
        {
            Pesos aux = (Pesos)dolar;
            return new Pesos(peso.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Pesos y otro del tipo Dolar.
        /// </summary>
        /// <param name="peso">Primer argumento a restar.</param>
        /// <param name="dolar">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la resta.</returns>
        public static Pesos operator -(Pesos peso, Dolar dolar)
        {
            Pesos aux = (Pesos)dolar;
            return new Pesos(peso.cantidad - aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Pesos y otro del tipo Euro.
        /// </summary>
        /// <param name="peso">Primer argumento a sumar.</param>
        /// <param name="euro">Segundo argumento a sumar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la suma.</returns>
        public static Pesos operator +(Pesos peso, Euro euro)
        {
            Pesos aux = (Pesos)euro;
            return new Pesos(peso.cantidad + aux.cantidad);
        }

        /// <summary>
        /// Suma dos argumentos uno del tipo Pesos y otro del tipo Euro.
        /// </summary>
        /// <param name="peso">Primer argumento a restar.</param>
        /// <param name="euro">Segundo argumento a restar.</param>
        /// <returns>Retorna un tipo de dato Pesos, con el valor de la resta.</returns>
        public static Pesos operator -(Pesos peso, Euro euro)
        {
            Pesos aux = (Pesos)euro;
            return new Pesos(peso.cantidad - aux.cantidad);
        }

    }
}
