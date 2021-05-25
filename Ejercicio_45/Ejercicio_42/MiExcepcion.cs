using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiExcepcion : Exception
    {

        public MiExcepcion()
            : base ("Se produjo excepcion del tipo MiExcepcion.")
        {

        }

        public MiExcepcion(string mensaje)
            : this (mensaje, null)
        {

        }

        public MiExcepcion(string mensaje, Exception innerException)
            : base (mensaje, innerException)
        {

        }

    }

}
