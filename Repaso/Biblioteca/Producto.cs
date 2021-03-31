using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que inicializa los atributos del Producto.
        /// </summary>
        /// <param name="marca">Marca del Producto.</param>
        /// <param name="codigoDeBarra">Codigo de Barra del Producto.</param>
        /// <param name="precio">Precio del Producto.</param>
        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene la marca del Producto.
        /// </summary>
        /// <returns>Retorna la marca del Producto en tipo de dato string.</returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Obtiene el precio del Producto.
        /// </summary>
        /// <returns>Retorna el precio del Producto en tipo de dato float.</returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Obtiene todos los datos del Producto brindado como argumento.
        /// </summary>
        /// <param name="producto">Producto del cual obtener los datos.</param>
        /// <returns>Retorna en formato de string, todos los datos del Producto (Marca,Precio,CodBarra).</returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Marca: {producto.GetMarca()}");
            retorno.AppendLine($"Precio: {producto.GetPrecio()}");
            retorno.AppendLine($"Codigo de Barra: {(string)producto}");
            return retorno.ToString();
        }

        #endregion

        #region OPERADORES

        /// <summary>
        /// Castea un tipo de dato Producto recibido como parametro a string.
        /// </summary>
        /// <param name="producto">Producto a castear a string.</param>
        /// <returns>Retorna el Codigo de Barra del producto con el tipo de dato string.</returns>
        public static explicit operator string(Producto producto)
        {
            string retorno = (string)producto.codigoDeBarra;
            return retorno;
        }


        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Producto.
        /// </summary>
        /// <param name="producto1">Primer argumento a comparar.</param>
        /// <param name="producto2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve TRUE si los argumentos son IGUALES.</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool retorno = false;
            //Valido si ALGUNO de los dos productos es NULL. Si alguno es NULL se sobreentiende que NO son iguales.
            //Por lo tanto, devuelvo FALSE en la variable retorno.
            if ( !(producto1 is null || producto2 is null) )
            {
                //Si ninguno de los dos productos recibidos es NULL, comparo su MARCA y CODBARRA.
                if (producto1.GetMarca() == producto2.GetMarca() &&
                   (string)producto1 == (string)producto2)
                {
                    retorno = true;//Devuelve TRUE, si son iguales.
                }
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad de dos argumentos del tipo Producto.
        /// </summary>
        /// <param name="producto1">Primer argumento a comparar.</param>
        /// <param name="producto2">Segundo argumento a comparar.</param>
        /// <returns>Devuelve TRUE si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1==producto2);
        }

        /// <summary>
        /// Compara la igualdad entre el atributo "marca" del Producto y el string recibidos.
        /// </summary>
        /// <param name="producto">Primer argumento a comparar.</param>
        /// <param name="marca">Segundo argumento a comparar.</param>
        /// <returns>Devuelve TRUE si los argumentos son IGUALES.</returns>
        public static bool operator ==(Producto producto, string marca)
        {
            bool retorno = false;
            //Comparo la marca del Producto y la marca recibida como string.
            if (producto.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara la igualdad entre el atributo "marca" del Producto y el string recibidos.
        /// </summary>
        /// <param name="producto">Primer argumento a comparar.</param>
        /// <param name="marca">Segundo argumento a comparar.</param>
        /// <returns>Devuelve TRUE si los argumentos son DISTINTOS.</returns>
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto==marca);
        }

        #endregion
    }
}
