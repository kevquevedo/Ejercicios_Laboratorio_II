using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int Medida = 400;

        public Agua(int capacidadML, string marca, int contenidoML)
            : base (marca, capacidadML, contenidoML)
        {

        }

        public override int ServirMedida()
        {
            return ServirMedida(Medida);
        }

        public int ServirMedida(int medida)
        {
            int retorno = 0;
            if (medida <= this.contenidoML)
            {
                this.contenidoML -= medida;
                retorno = this.contenidoML;
            }
            else
            {
                this.contenidoML = 0;
            }
            return retorno;
        }

        protected new string GenerarInforme()
        {
            return base.ToString();
        }


    }
}
