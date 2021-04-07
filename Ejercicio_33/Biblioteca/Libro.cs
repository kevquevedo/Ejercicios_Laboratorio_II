using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        //CONSTRUCTOR DE LA LISTA
        public Libro()
        {
            paginas = new List<string>();
        }

        //INDEXADOR
        public string this[int i]
        {
            //GETTER
            get
            {
                string retorno = String.Empty; //Declaro un string vacio, en caso de que no entre al IF.
                if (i < this.paginas.Count() && i >= 0)//Si el indice, esta dentro del rango de la List, lo retorno.
                {
                    retorno = this.paginas[i];//Asigno el string en la posicion del indice, a la variable del retorno.
                }
                return retorno;
            }
            //SETTER
            set
            {
                //Si el indice, es menor a la cantidad y mayor o igual a 0. 
                //Lo seteo en un lugar ya "precargado".
                if (i < this.paginas.Count() && i >= 0)
                {
                    paginas[i] = value;
                }
                //Si el indice es mayor o igual a la cantidad, agrego una pagina al final.
                else if(i >= this.paginas.Count())
                {
                    paginas.Add(value);
                }
            }
        } 

    }
}
