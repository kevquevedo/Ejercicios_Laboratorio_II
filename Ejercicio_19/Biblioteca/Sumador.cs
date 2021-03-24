using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        //PUNTO A
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }

        //PUNTO B
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        //PUNTO C
        public static explicit operator int(Sumador s)
        {
            int retorno = (int)s.cantidadSumas;
            return retorno;
        }

        //PUNTO D
        public static long operator +(Sumador s1, Sumador s2)
        {
            long retorno = s1.cantidadSumas + s2.cantidadSumas;
            return retorno;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
