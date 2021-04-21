using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if(capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
        }


        public float CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return ((contenidoML * 100) / capacidadML);
            }
        }

        public abstract int ServirMedida();


        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Capacidad: {this.capacidadML}ml");
            sb.AppendLine($"Contenido: {this.contenidoML}ml");
            sb.AppendLine($"Porcentaje de contenido: {this.PorcentajeContenido}%");

            return sb.ToString();
        } 

        public new string ToString()
        {
            return this.GenerarInforme();
        }

        public enum Tipo
        {
            Vidrio,
            Plastico
        }
    }



}
