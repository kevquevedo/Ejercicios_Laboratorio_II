using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        /// <summary>
        /// Constructor publico que inicializa los atributos de Llamada Provincial.
        /// </summary>
        /// <param name="miFranja">Franka de la Llamada Provincial.</param>
        /// <param name="llamada">Llamada Provincial recibida.</param>
        public Provincial(Franja miFranja, Llamada llamada)
            : this (llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de Llamada Provincial.
        /// </summary>
        /// <param name="origen">Origen de la Llamada Provincial.</param>
        /// <param name="miFranja">Franja de la Llamada Provincial.</param>
        /// <param name="duracion">Duracion de la Llamada Provincial.</param>
        /// <param name="destino">Destino de la Llamada Provincial.</param>
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        /// <summary>
        /// Propiedad de lectura del costo de una Llamada Provincial.
        /// </summary>
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        /// <summary>
        /// Metodo que calcula el costo de la Llamada Provincial de acuerdo a la Franja Horaria.
        /// </summary>
        /// <returns>Retorna el valor de la Llamada Provincial.</returns>
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(0.99 * this.Duracion);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(1.25 * this.Duracion);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(0.66 * this.Duracion);
                    break;
                default:
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo sobreescrito que muestra los datos de una Llamada Provincial.
        /// </summary>
        /// <returns>Retorna los datos de una Llamada Provincial.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            sb.Append($"Costo de llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que retorna la informacion de la Llamada Provincial.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la Llamada Provincial.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Metodo que compara si el objeto recibido por parametro es Llamada Provincial.
        /// </summary>
        /// <param name="obj">Objeto recibido.</param>
        /// <returns>Retorna TRUE, si el objeto recibido es una Llamada Provincial.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Provincial)
            {
                retorno = true;
            }
            return retorno;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }

    /// <summary>
    /// Enumerador de las Franjas Horarias de la Llamada Provincial.
    /// </summary>

}
