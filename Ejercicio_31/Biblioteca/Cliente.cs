using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        /// <summary>
        /// Propiedad que obtiene el numero de un Cliente.
        /// </summary>
        /// <returns>Retorna el numero de un Cliente.</returns>
        public int Numero 
        {
            get
            {
                return this.numero;
            } 
        }

        /// <summary>
        /// Propiedad que obtiene el nombre de un Cliente.
        /// </summary>
        /// <returns>Retorna el nombre de un Cliente.</returns>
        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Constructor que inicializa el numero del Cliente, segun parametro brindado.
        /// </summary>
        /// <param name="numero">Numero de telefono del Cliente.</param>
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que inicializa el numero y el nombre del Cliente, segun parametros brindados.
        /// </summary>
        /// <param name="numero">Numero de telefono del Cliente.</param>
        /// <param name="nombre">Nombre de telefono del Cliente.</param>
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Compara si dos Clientes son iguales por su numero telefonico.
        /// </summary>
        /// <param name="cliente1">Primer Cliente a comparar.</param>
        /// <param name="cliente2">Segundo Cliente a comparar.</param>
        /// <returns>Retorna TRUE, si los clientes son IGUALES.</returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if(cliente1.Numero == cliente2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara si dos Clientes son distintos por su numero telefonico.
        /// </summary>
        /// <param name="cli1">Primer Cliente a comparar.</param>
        /// <param name="cli2">Segundo Cliente a comparar.</param>
        /// <returns>Retorna TRUE, si los clientes son DISTINTOS.</returns>
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }

    }
}
