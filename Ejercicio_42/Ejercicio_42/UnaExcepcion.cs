using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class UnaExcepcion : Exception
    {

        public UnaExcepcion()
            : base ("Se produjo excepcion del tipo UnaExcepcion.")
        {

        }

        public UnaExcepcion(string mensaje)
            : this (mensaje, null)
        {

        }

        public UnaExcepcion(string mensaje, Exception innerExcepcion)
            : base (mensaje, innerExcepcion)
        {

        }
    }
}
