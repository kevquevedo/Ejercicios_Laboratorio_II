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

        public Local(Llamada llamada, float costo) 
            : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
    
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
            //return base.Duracion * this.costo;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append($"Costo de llamada: {this.CostoLlamada}");

            return sb.ToString();
        }


    }
}
