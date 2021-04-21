using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SobreSobreescrito : Sobreescrito
    {

        protected override string MiPropiedad
        {
            get
            {
                return this.miatributo;
            }      
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
