using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char caracter)
        {
            bool retorno = false;
            if (caracter == 'S' || caracter == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
