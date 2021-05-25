using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {

        public MiClase()
        {
            try
            {
                MiClase.MetodoMiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int i)
        {
            try
            {
                MiClase clase = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("UNA EXCEPCION !!!", ex);
            }
        }

        public static void MetodoMiClase()
        {
            throw new DivideByZeroException("EXCEPCION DIVIDEBYZERO");
        }

    }
}
