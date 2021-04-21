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


        public Centralita()
        {
            this.listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Todas);
            }
        }


        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            sb.AppendLine("");
            sb.AppendLine("Detalle de llamadas:");
            sb.AppendLine("");
            foreach (Llamada item in this.Llamadas)
            {
                if(item is Local local)
                {
                    sb.AppendLine(local.Mostrar());
                    sb.AppendLine("");
                }
                else
                {
                    sb.AppendLine(((Provincial)item).Mostrar());
                    sb.AppendLine("");
                }
            }
            sb.AppendLine("======================================================");
            return sb.ToString();
        }

        private float CalcularGanancia(TipoLLamada tipo)
        {
            float retorno = 0;

            switch (tipo)
            {
                case TipoLLamada.Local:

                    foreach (Llamada item in this.Llamadas)
                    {
                        Local llamada = item as Local;
                        if(llamada != null)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                    }
                    break;

                case TipoLLamada.Provincial:

                    foreach (Llamada item in this.Llamadas)
                    {
                        Provincial llamada = item as Provincial;
                        if (llamada != null)
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

    }
}
