using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor privado que inicializa la capacidad del Estante.
        /// </summary>
        /// <param name="capacidad">Capacidad del Estante a instanciar.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Constructor que inicializa los atributos del Estante.
        /// </summary>
        /// <param name="capacidad">Capacidad del Estante a instanciar.</param>
        /// <param name="ubicacion">Ubicación del Estante a instanciar.</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)//Reutilizo codigo, en este caso
        {                                                             //el constructor private.
            this.ubicacionEstante = ubicacion;
        }

        #endregion

        #region GETTERS

        /// <summary>
        /// Obtiene un Array de Productos.
        /// </summary>
        /// <returns>Retorna el Array de productos de un Estante.</returns>
        public Producto[] GetProductos()
        {
            return this.productos;//Devuelvo el Array, directamente "productos" porque es del tipo Producto[].
        }

        /// <summary>
        /// Obtiene todos los datos de un Estante, inclusive sus Productos.
        /// </summary>
        /// <param name="estante">Estante del cual obtener los datos.</param>
        /// <returns>Retorna en formato de string, todos los datos del Estante.</returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder retorno = new StringBuilder();
            //Valido si el Estante NO es NULL. Acordarse que lo niego '!'.
            if(!(estante is null))
            {
                //Si no es NULL, apendeo su ubicación.
                retorno.AppendLine($"La ubicacion del estante es: {estante.ubicacionEstante}");
                foreach (Producto item in estante.GetProductos()) //Recorro el array de productos del estante recibido.
                {
                    //Valido que NO sea NULL.
                    if(!(item is null))
                    {//Si no es NULL, es porque tiene un producto cargado, por eso apendeo la informacion del Producto.
                        retorno.AppendLine(Producto.MostrarProducto(item));
                    }
                }
            }
            return retorno.ToString();//Retorno TODO lo apendeado.
        }

        #endregion

        #region OPERADORES

        /// <summary>
        /// Valida si el Producto recibido se encuentra en el Estante.
        /// </summary>
        /// <param name="estante">Estante en donde buscar el Producto.</param>
        /// <param name="producto">Producto a buscar en el Estante.</param>
        /// <returns>Devuelve TRUE si el Producto, ya existe en el Estante.</returns>
        public static bool operator ==(Estante estante, Producto producto)
        {
            bool retorno = false;
            //Valido que ni el ESTANTE ni el PRODUCTO, sean NULL. Si, son NULL, la busqueda arroja false.
            if (!(estante is null || producto is null))
            {
                //Si ambos objetos existen, recorro los Productos del Estante.
                foreach (Producto item in estante.GetProductos())
                {
                    //Valido que cada Producto "sacado" del Estante, NO sea igual al Producto recibido
                    //como parametro y que el Producto "sacado" no sea NULL (Porque no seria una comparacion logica).
                    if (item == producto && !(item is null) )
                    {
                        retorno = true;//Si es verdadero, es porque el Producto ya existe en el Estante
                        break;         //Por ende, devuelve TRUE y rompo el foreach.
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida si el Producto recibido NO se encuentra en el Estante.
        /// </summary>
        /// <param name="estante">Estante en donde buscar el Producto.</param>
        /// <param name="producto">Producto a buscar en el Estante.</param>
        /// <returns>Devuelve TRUE si el Producto, NO existe en el Estante.</returns>
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante==producto);
        }

        /// <summary>
        /// Suma un Producto a un Estante.
        /// </summary>
        /// <param name="estante">Estante en donde sumar el Producto.</param>
        /// <param name="producto">Producto a sumar al Estante.</param>
        /// <returns>Devuelve TRUE si el Producto, pudo sumarse al Estante.</returns>
        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno = false;
            //Valido que ni el ESTANTE ni el PRODUCTO, sean NULL. Si, son NULL, la busqueda arroja false.
            //Ademas, valido que el Producto NO esté en la lista, porque no tiene sentido agregar un
            //producto que ya existe.
            if (!(estante is null || producto is null) &&
                (estante != producto) )
            {
                //Si el Producto no existe, recorro el Estante, para verificar si hay lugar para ubicarlo.
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    if (estante.productos[i] is null)//Valido si el Producto es NULL. Si lo es, es porque esta vacio.
                    {
                        estante.productos[i] = producto;//Entonces lo guardo en la ubicacion 'i' porque esta vacio
                        retorno = true;                 //Devuelvo TRUE, porque lo pude agregar al Estante. 
                        break;                          //Rompo el foreach.
                    }
                }   
            }
            return retorno;
        }

        /// <summary>
        /// Resta un Producto de un Estante.
        /// </summary>
        /// <param name="estante">Estante en donde restar el Producto.</param>
        /// <param name="producto">Producto a restar al Estante.</param>
        /// <returns>Devuelve TRUE si el Producto, pudo restarse al Estante.</returns>
        public static bool operator -(Estante estante, Producto producto)
        {
            bool retorno = false;
            //Valido que ni el ESTANTE ni el PRODUCTO, sean NULL. Si, son NULL, la busqueda arroja false.
            if (!(estante is null || producto is null))
            {
                //Recorro el Array de Productos del Estante recibido como argumento.
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    //Si el producto "sacado" del Array, es igual al Producto del argumento, quiere decir
                    //que lo tengo que eliminar.
                    if (estante.productos[i] == producto)
                    {
                        estante.productos[i] = null;//Lo elimino, apuntando esa direccion a NULL, indicando que esta "vacio".
                        retorno = true;// Devuelvo TRUE, porque lo pude restar.
                        break;         //Rompo el for, porque si ya lo encontré no tiene sentido seguir iterando.
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
