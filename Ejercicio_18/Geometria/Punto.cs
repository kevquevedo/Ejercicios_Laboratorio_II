using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        /// <summary>
        /// Constructor de un Punto.
        /// </summary>
        /// <param name="x">Coordenada X a asignar al Punto.</param>
        /// <param name="y">Coordenada Y a asignar al Punto.</param>
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Obtiene el valor de la coordenada X del Punto.
        /// </summary>
        /// <returns> Retorna el valor de la coordenada X del Punto.</returns>
        public int GetX()
        {
            return this.x;
        }

        /// <summary>
        /// Obtiene el valor de la coordenada Y del Punto.
        /// </summary>
        /// <returns> Retorna el valor de la coordenada Y del Punto.</returns>
        public int GetY()
        {
            return this.y;
        }
    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        /// <summary>
        /// Constructor privado del Rectangulo, para inicializar sus atributos.
        /// </summary>
        private Rectangulo()
        {
            this.area = 0;
            this.perimetro = 0;
            this.vertice1 = null;
            this.vertice2 = null;
            this.vertice3 = null;
            this.vertice4 = null;
        }

        /// <summary>
        /// Constructor por vertices del Rectangulo.
        /// </summary>
        /// <param name="vertice1"> Obtiene el vertice1 segun las coordenadas del punto brindado como parametro.</param>
        /// <param name="vertice3"> Obtiene el vertice3 segun las coordenadas del punto brindado como parametro.</param>
        public Rectangulo(Punto vertice1, Punto vertice3) : this()
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        /// <summary>
        /// Obtiene el Area del Rectangulo.
        /// </summary>
        /// <returns> Retorna el valor del area del Rectangulo.</returns>
        public float Area()
        {
            //Valido que los vertices no sean NULL y que el Area sea 0 (Para calcularlo solo una vez).
            if (!(vertice1 is null || vertice3 is null) && this.area == 0)
            {
                float alturaRect = Math.Abs(vertice1.GetY() - vertice3.GetY());
                float baseRect = Math.Abs(vertice1.GetX() - vertice3.GetX());
                this.area = alturaRect * baseRect;
            }
            return this.area;
        }

        /// <summary>
        /// Obtiene el Perimetro del Rectangulo.
        /// </summary>
        /// <returns> Retorna el valor del perimetro del Rectangulo.</returns>
        public float Perimetro()
        {
            //Valido que los vertices no sean NULL y que el Perimetro sea 0 (Para calcularlo solo una vez).
            if (!(vertice1 is null || vertice3 is null) && this.perimetro == 0)
            {
                float alturaRect = Math.Abs(vertice1.GetY() - vertice3.GetY());
                float baseRect = Math.Abs(vertice1.GetX() - vertice3.GetX());
                this.perimetro = (alturaRect * 2) + (baseRect * 2);
            }
            return this.perimetro;
        }

        /// <summary>
        /// Muestra los datos de un objeto Rectangulo que recibe como parametro.
        /// </summary>
        /// <param name="rect">Rectangulo recibido para mostrar datos.</param>
        /// <returns>Retorna un string con todos los datos del Rectangulo.</returns>
        public static string MostrarDatos(Rectangulo rect)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL RECTANGULO: ");
            sb.AppendLine($"El Area es: {rect.Area()}");
            sb.AppendLine($"El Perimetro es: {rect.Perimetro()}");
            sb.AppendLine($"El Vertice Uno: X = {rect.vertice1.GetX()} / Y = {rect.vertice1.GetY()}");
            sb.AppendLine($"El Vertice Dos: X = {rect.vertice2.GetX()} / Y = {rect.vertice2.GetY()}");
            sb.AppendLine($"El Vertice Tres: X = {rect.vertice3.GetX()} / Y = {rect.vertice3.GetY()}");
            sb.AppendLine($"El Vertice Cuatro: X = {rect.vertice4.GetX()} / Y = {rect.vertice4.GetY()}");
            return sb.ToString();
        }
    }

}
