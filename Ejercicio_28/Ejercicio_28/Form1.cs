using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            string texto = richTextBox.Text;//Lo que obtengo del Cuadro de Texto, lo vuelvo a un string.
            //Aca "Split" determina un separador para el string, y lo vuelca a un array de strings.
            //Esto para separar cada palabra por espacios.
            string[] arrayPalabras = texto.Split(' '); 

            for (int i = 0; i < arrayPalabras.Length; i++) //Recorro el array de palabras que generé.
            {
                if (diccionario.ContainsKey(arrayPalabras[i]))//Si el diccionario contiene la palabra del indice "i".
                {
                    diccionario[arrayPalabras[i]]++;//Incremento el valor (Value) de esa palabra en el diccionario.
                }
                else
                {
                    diccionario.Add(arrayPalabras[i], 1);//Si la palabra no existe la agrego al diccionario.
                }
            }            
            MessageBox.Show(MensajeTopPalabras(diccionario)); //Imprimo por Box, el top de palabras segun el metodo.
        }

        
        /// <summary>
        /// Imprime el top 3 de las palabras mas utilizadas del diccionario.
        /// </summary>
        /// <param name="diccionario">Diccionario de donde tomar palabras.</param>
        /// <returns></returns>
        private static string MensajeTopPalabras(Dictionary<string, int> diccionario)
        {
            //Primero convierto el diccionario en una lista. Dictionary --> List.
            List<KeyValuePair<string, int>> listaDiccionario = new List<KeyValuePair<string, int>>(diccionario.ToList());
            listaDiccionario.Sort(Ordenamiento); //Uso el ordenamiento que realice.
            StringBuilder sb = new StringBuilder();
            int topPalabra = 3;

            //Recorro la lista y la transformo a Clave/Valor.
            foreach (KeyValuePair<string, int> item in listaDiccionario)
            {     
                if (topPalabra > 0) //If, para solo tener en cuenta determinada cantidad de palabras.
                {
                    sb.AppendLine($"Palabra: {item.Key} / Cantidad: {item.Value}");
                    topPalabra--;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Metodo de ordenamiento descendente segun la cantidad de palabras.
        /// </summary>
        /// <param name="palabra1">Primer palabra a ordenar.</param>
        /// <param name="palabra2">Segunda palabra a ordenar.</param>
        /// <returns>Recibe un numero positivo si la segunda palabra, posee mayor cantidad.</returns>
        private static int Ordenamiento(KeyValuePair<string, int> palabra1, KeyValuePair<string, int> palabra2)
        {
            return palabra2.Value - palabra1.Value;
        }
    }
}
