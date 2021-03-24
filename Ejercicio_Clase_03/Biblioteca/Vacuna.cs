using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vacuna
    {
        private string nombre;

        //Constructor de Vacuna
        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        //Getter nombre de Vacuna
        public string NombreVacuna()
        {
            return this.nombre;
        }
    }
}
