using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int Medida = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML)
            : base (marca, capacidadML, contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : this (capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }


        public override int ServirMedida()
        {
            int retorno = 0;
            int medidaSinEspuma = (int)(Medida * 0.8);
            if (medidaSinEspuma <= this.contenidoML)
            {
                this.contenidoML -= medidaSinEspuma;
                retorno = this.contenidoML - medidaSinEspuma;
            }
            else
            {
                this.contenidoML = 0;
            }
            return retorno;
        }


        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }


    }
}
