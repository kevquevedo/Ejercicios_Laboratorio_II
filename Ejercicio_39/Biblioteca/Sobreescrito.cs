using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Sobreescrito
    {
        protected string miatributo;

        public Sobreescrito()
        {
            miatributo = "Probar abstractos";
        }

        protected abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Sobreescrito)
            {
                retorno = true;
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            int retorno = 1142510187;
            return retorno;
        }
    }
}
