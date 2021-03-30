using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;

namespace Ejercicio_21
{
    class Ejercicio_21
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 21";

            //PRUEBA DE CONSTRUCTOR, GETTER Y CONVERSORES
            /*
            Celsius celsius1 = new Celsius(6);
            Fahrenheit fahrenheit = (Fahrenheit)celsius1;

            Console.WriteLine($"El valor de {celsius1.GetTemperatura()} Celsius es: {fahrenheit.GetTemperatura()} fahrenheit");
            */

            //CONVERSION DE CELSIUS A KELVIN
            /*
            double valor = 10;
            Celsius celsius = new Celsius(valor);

            Kelvin kelvin = (Kelvin)celsius;

            Console.WriteLine($"El valor de {celsius.GetTemperatura()} Celsius es: {kelvin.GetTemperatura()} Kelvin");
            */

            //CONVERSION DE KELVIN A CELSIUS
            /*
            double valor = 2;
            Kelvin kelvin = new Kelvin(valor);

            Celsius celsius = (Celsius)kelvin;

            Console.WriteLine($"El valor de {kelvin.GetTemperatura()} Kelvin es: {celsius.GetTemperatura()} Celsius");
            */

            //PRUEBA SUMA
            /*
            Kelvin kelvin = new Kelvin(2);
            Celsius celsius = new Celsius(20);

            Kelvin suma = kelvin + celsius;
            Console.WriteLine($"La suma equivale a: {suma.GetTemperatura()}° Kelvin.");
            */

            Console.ReadKey();
        }
    }
}
