using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        string nombre;
        string apellido;
        long dni;
        string[] formasPago;

        public Usuario(string nombre, string apellido, long dni, string[] formasPago)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.formasPago = formasPago;
        }
    }
}
