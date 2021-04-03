using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        private static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        /// <summary>
        /// Constructor del Boligrafo.
        /// </summary>
        /// <param name="tinta">Cantidad de tinta a asignar al Boligrafo.</param>
        /// <param name="color">Color a asignar al Boligrafo.</param>
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// Obtiene el color del Boligrafo.
        /// </summary>
        /// <returns>Retorna el color del Boligrafo.</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Obtiene la cantidad de tinta del Boligrafo.
        /// </summary>
        /// <returns>Retorna la cantidad de tinta del Boligrafo.</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Setea la cantidad de tinta de un Boligrafo.
        /// </summary>
        /// <param name="tinta">Cantidad de tinta a setear en el Boligrafo.</param>
        private void SetTinta(short tinta)
        {
            short resultado = (short)(this.tinta + tinta);
            //Si la capacidad de la tinta (this.tinta), supera los limites de 0 a 100
            //se los harcodeo como tope.
            if (resultado <= 0)
            {
                this.tinta = 0;//Limite minimo
            }
            else if(resultado >= cantidadTintaMaxima)
            {

                this.tinta = cantidadTintaMaxima;//Limite Maximo.
            }
            else
            {
                //Si no supera ninguno de los dos limites, se encuentra dentro del rango, entonces
                //Realizo el calculo correspondiente y se lo asigno a la cantidad de tinta.
                this.tinta = (short)(this.tinta + tinta);
            }
        }

        /// <summary>
        /// Recarga el Boligrafo a su capacidad maxima.
        /// </summary>
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Pinta tantos "*", como los que reciba de gasto y segun la capacidad del Boligrafo.
        /// </summary>
        /// <param name="gasto">Gasto realizado y "*" a pintar.</param>
        /// <param name="dibujo">Array de string con los "*" pintados.</param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            short auxiliar = (short)(gasto * -1);//Si es gasto, va en negativo. Realizo la conversion de signo.
            dibujo = null;
            
            //Valido que la capacidad de tinta del Boligrafo con el gasto, sea mayor a 0. 
            if( (GetTinta() + auxiliar) > 0 )
            {
                SetTinta(auxiliar);//Si es mayor a 0, le seteo el nuevo nivel de tinta.
                retorno = true;//Retorno TRUE, porque SI pude pintar.
                //Genero un StringBuilder y retorno tantos "*" como tenga de "gasto".
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < gasto; i++)
                {
                    sb.Append("*");
                }
                dibujo = sb.ToString();//A la variable dibujo, pasada como referencia, le asigno el StringBuilder.
            }
            return retorno;
        }


    }
}
