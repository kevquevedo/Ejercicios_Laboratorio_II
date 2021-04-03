using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string nombre;
        private string apellido;
        private int legajo;

        /// <summary>
        /// Constructor del objeto Alumno.
        /// </summary>
        /// <param name="nombre">Nombre a asignar al objeto Alumno.</param>
        /// <param name="apellido">Apellido a asignar al objeto Alumno.</param>
        /// <param name="legajo">Legajo a asignar al objeto Alumno.</param>
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        /// <summary>
        /// Metodo que asigna dos notas al objeto Alumno y calcula la nota final.
        /// </summary>
        /// <param name="notaUno">Primer nota del objeto Alumno.</param>
        /// <param name="notaDos">Segunda nota del objeto Alumno.</param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
            CalcularFinal();
        }

        /// <summary>
        /// Metodo que calcula la nota final del alumno.
        /// </summary>
        public void CalcularFinal()
        {
            this.notaFinal = -1;
            //Si ambas notas son mayores o iguales a 4, realizo el calculo de la nota final.
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random rndFinal = new Random();
                this.notaFinal = rndFinal.Next(this.nota1, this.nota2);
            }
        }

        /// <summary>
        /// Metodo que muestra la informacion del Alumno.
        /// </summary>
        /// <returns>Retorna un String con toda la informacion del objeto Alumno.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            //Si la nota es distinta a -1, le muestro la nota final, sino indico que esta "desaprobado".
            if (this.notaFinal == -1)
            {
                sb.Append("Alumno Desaprobado");
            }
            else
            {
                sb.Append($"La Nota Final del alumno es: {this.notaFinal}");
            }
            return sb.ToString();
        }

    }
}
