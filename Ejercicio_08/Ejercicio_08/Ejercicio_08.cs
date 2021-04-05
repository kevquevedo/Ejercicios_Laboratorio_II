using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 8";

            Console.Write("Por favor, ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Por favor, ingrese el valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());
            Console.Write("Por favor, ingrese la antiguedad: ");
            int antiguedad = int.Parse(Console.ReadLine());
            Console.Write("Por favor, ingrese la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            double impACobrar = valorPorHora * horasTrabajadas;
            double impAntiguedad = antiguedad * 150;
            double totalBruto = impACobrar + impAntiguedad;
            double descuento = totalBruto * 0.13;
            double totalNeto = totalBruto - descuento;

            Console.WriteLine("----------------------------------------");

            StringBuilder datosEmpleado = new StringBuilder();
            datosEmpleado.AppendLine($"Nombre del Empleado: {nombre}");
            datosEmpleado.AppendLine($"Antiguedad: {antiguedad}");
            datosEmpleado.AppendLine($"Valor por hora: {valorPorHora}");
            datosEmpleado.AppendLine($"Importe a Cobrar Bruto: {totalBruto:0.00}");
            datosEmpleado.AppendLine($"Importe de Descuento: {descuento:0.00}");
            datosEmpleado.AppendLine($"Importe a Cobrar Neto: {totalNeto:0.00}");
            Console.WriteLine(datosEmpleado.ToString());

            Console.ReadKey();
        }
    }
}
