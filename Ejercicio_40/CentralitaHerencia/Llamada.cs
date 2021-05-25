using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /// <summary>
        /// Constructor publico que inicializa los atributos de Llamada.
        /// </summary>
        /// <param name="duracion">Duración a asignar a la Llamada.</param>
        /// <param name="nroDestino">Destino a asignar a la Llamada.</param>
        /// <param name="nroOrigen">Origen a asignar a la Llamada.</param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura de costo de la Llamada.
        /// </summary>
        public abstract float CostoLlamada { get; }

        /// <summary>
        /// Propiedad de lectura de duración de la Llamada.
        /// </summary>
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        /// <summary>
        /// Propiedad de lectura de destino de la Llamada.
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        /// <summary>
        /// Propiedad de lectura de origen de la Llamada.
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion


        #region METODOS

        /// <summary>
        /// Metodo que ordena por duracion las Llamadas.
        /// </summary>
        /// <param name="llamada1">Primer Llamada a ordenar.</param>
        /// <param name="llamada2">Segunda Llamada a ordenar.</param>
        /// <returns>Retorna un valor positivo la primer llamada es mas duradera, negativa si la segunda lo es, y 0 si poseen la misma duración.</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.Duracion - llamada2.Duracion);
        } 

        /// <summary>
        /// Muestra los atributos destino, origen, duración de la Llamada.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la Llamada.</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nro. Destino: {this.NroDestino}");
            sb.AppendLine($"Nro. Origen: {this.NroOrigen}");
            sb.Append($"Duracion: {this.Duracion}");

            return sb.ToString();
        }

        #endregion

        /// <summary>
        /// Operador de igualdad, que compara que si dos Llamadas son iguales.
        /// </summary>
        /// <param name="llama1">Primer Llamada a analizar.</param>
        /// <param name="llama2">Segunda Llamada a analizar.</param>
        /// <returns>Retorna TRUE, si las llamadas son iguales.</returns>
        public static bool operator ==(Llamada llama1, Llamada llama2)
        {
            bool retorno = false;

            if (!(llama1 is null) || !(llama2 is null))
            {
                if (llama1.Equals(llama2) &&
                    llama1.NroDestino == llama2.NroDestino &&
                    llama1.NroOrigen == llama2.NroOrigen)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Operador de igualdad, que compara que si dos Llamadas son distintas.
        /// </summary>
        /// <param name="llama1">Primer Llamada a analizar.</param>
        /// <param name="llama2">Segunda Llamada a analizar.</param>
        /// <returns>Retorna TRUE, si las llamadas son distintas.</returns>
        public static bool operator !=(Llamada llama1, Llamada llama2)
        {
            return !(llama1 == llama2);
        }

    }

    /// <summary>
    /// Enumerador de tipos de Llamada.
    /// </summary>
    public enum TipoLLamada
    {
        Local,
        Provincial,
        Todas
    }
}
