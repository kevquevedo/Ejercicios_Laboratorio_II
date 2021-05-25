using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {


        public void MetodoOtraClase()
        {
            try
            {
                MiClase clase = new MiClase(2);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("MI EXCEPCION !!", ex);
            }
        }

    }
}
