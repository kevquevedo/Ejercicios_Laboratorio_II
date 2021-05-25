using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        /// <summary>
        /// Constructor publico que inicializa los atributos de Llamada Local.
        /// </summary>
        /// <param name="llamada">Llamada local recibida.</param>
        /// <param name="costo">Costo de la llamada.</param>
        public Local(Llamada llamada, float costo) 
            : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
    
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de Llamada Local.
        /// </summary>
        /// <param name="origen">Origen a asignar a la Llamada Local.</param>
        /// <param name="duracion">Duracion a asignar a la Llamada Local.</param>
        /// <param name="destino">Destino a asignar a la Llamada Local.</param>
        /// <param name="costo">Costo a asignar a la Llamada Local.</param>
        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Propiedad de lectura del costo de una Llamada Local.
        /// </summary>
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        /// <summary>
        /// Metodo que calcula el costo de la Llamada Local.
        /// </summary>
        /// <returns>Retorna el valor de la Llamada Local.</returns>
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        /// <summary>
        /// Metodo sobreescrito que muestra los datos de una Llamada Local.
        /// </summary>
        /// <returns>Retorna los datos de una Llamada Local.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append($"Costo de llamada: {this.CostoLlamada:0.00}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que retorna la informacion de la Llamada Local.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la Llamada Local.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Metodo que compara si el objeto recibido por parametro es Llamada Local.
        /// </summary>
        /// <param name="obj">Objeto recibido.</param>
        /// <returns>Retorna TRUE, si el objeto recibido es una Llamada Local.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
