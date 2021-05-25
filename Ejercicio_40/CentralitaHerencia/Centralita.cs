using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamadas;
        private string razonSocial;

        /// <summary>
        /// Constructor publico que inicializa la lista de Llamadas de Centralita.
        /// </summary>
        public Centralita()
        {
            this.listaDeLLamadas = new List<Llamada>();
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de Centralita.
        /// </summary>
        /// <param name="nombreEmpresa">Nombre a asignar a la Centralita.</param>
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la lista de Llamadas.
        /// </summary>
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la ganancia por las Llamadas Locales.
        /// </summary>
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Local);
            }
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la ganancia por las Llamadas Provinciales.
        /// </summary>
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Provincial);
            }
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la ganancia por todas las Llamadas.
        /// </summary>
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Todas);
            }
        }

        /// <summary>
        /// Metodo que ordena las Llamadas de la Centralita.
        /// </summary>
        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        /// <summary>
        /// Metodo privado que retorna la informacion de una Centralita.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la Centralita.</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            sb.AppendLine();
            sb.AppendLine("Detalle de llamadas:");
            sb.AppendLine();
            foreach (Llamada item in this.Llamadas)
            {
                if(item is Local local)
                {
                    sb.AppendLine(local.ToString());
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine(((Provincial)item).ToString());
                    sb.AppendLine();
                }
            }
            sb.AppendLine("======================================================");
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que retorna la informacion de una Centralita.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la Centralita.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Metodo que calcula la ganancia de las Llamadas, según tipo de las mismas.
        /// </summary>
        /// <param name="tipo">Tipo de las Llamadas a analizar.</param>
        /// <returns>Retorna el valor de ganancia del tipo de llamada brindado como parametro.</returns>
        private float CalcularGanancia(TipoLLamada tipo)
        {
            float retorno = 0;

            switch (tipo)
            {
                case TipoLLamada.Local:

                    foreach (Llamada item in this.Llamadas)
                    {
                        Local llamada = item as Local;
                        if(!(llamada is null))
                        {
                            retorno += llamada.CostoLlamada;
                        }
                    }
                    break;

                case TipoLLamada.Provincial:

                    foreach (Llamada item in this.Llamadas)
                    {
                        Provincial llamada = item as Provincial;
                        if (!(llamada is null))
                        {
                            retorno += llamada.CostoLlamada;
                        }
                    }
                    break;

                case TipoLLamada.Todas:

                    foreach (Llamada item in this.Llamadas)
                    {
                        if(item is Local llamada)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                        else
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                    }
                    break;

                default:
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo privado que agrega una nueva Llamada a la lista.
        /// </summary>
        /// <param name="llamadaNueva">Llamada a agregar a la lista.</param>
        private void AgregarLlamada(Llamada llamadaNueva)
        {
            this.Llamadas.Add(llamadaNueva);
        }

        /// <summary>
        /// Operador de igualdad, que analiza si la Llamada se encuentra en la Centralita.
        /// </summary>
        /// <param name="centra">Centralita a analizar.</param>
        /// <param name="llamada">Llamada a analizar.</param>
        /// <returns>Retorna TRUE, si la Llamada se encuentra en la Centralita.</returns>
        public static bool operator ==(Centralita centra, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada item in centra.Llamadas)
            {
                if(llamada == item)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Operador de igualdad, que analiza si la Llamada se encuentra en la Centralita.
        /// </summary>
        /// <param name="centra">Centralita a analizar.</param>
        /// <param name="llamada">Llamada a analizar.</param>
        /// <returns>Retorna TRUE, si la Llamada NO se encuentra en la Centralita.</returns>
        public static bool operator !=(Centralita centra, Llamada llamada)
        {
            return !(centra == llamada);
        }

        /// <summary>
        /// Operador que agrega una Llamada a la Centralita, si es que no existe en la misma.
        /// </summary>
        /// <param name="centra">Centralita a analizar.</param>
        /// <param name="llamada">Llamada a analizar.</param>
        /// <returns>Retorna TRUE, si agregó la Llamada a la Centralita.</returns>
        public static bool operator +(Centralita centra, Llamada llamada)
        {
            bool retorno = false;
            if(centra != llamada)
            {
                centra.AgregarLlamada(llamada);
                retorno = true;
            }
            return retorno;
        }

    }
}
