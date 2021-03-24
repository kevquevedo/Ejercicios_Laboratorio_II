using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
            //PROBAR DE PESOS A DOLARES
            double montoPesos = 198;
            Pesos pruebaPesos3 = new Pesos(montoPesos);
            Dolar trasPesos = (Dolar)pruebaPesos3;
            Console.WriteLine($"El traspaso P a D es: {trasPesos.GetCantidad():0.00}");
            */

            /*
            //PROBAR DE PESOS A EUROS
            double montoPesos2 = 132;
            Pesos pruebaPesos4 = new Pesos(montoPesos2);
            Euro trasEuro = new Euro(1);
            trasEuro = (Euro)pruebaPesos4;
            Console.WriteLine($"El traspaso P a E es: {trasEuro.GetCantidad():0.00}");
            */

            /*
            //PROBAR DE EUROS A PESOS
            Euro trasEuro = new Euro(1);
            Pesos trasPeso = new Pesos(1);
            trasPeso = (Pesos)trasEuro;
            Console.WriteLine($"El traspaso P a E es: {trasPeso.GetCantidad():0.00}");
            */

            /*
            //COMPARACION DE PESOS VS DOLARES
            Pesos peso1 = new Pesos(66);
            Pesos peso2 = new Pesos(68);
            Dolar dolar1 = new Dolar(1);

            Console.WriteLine($"1° son iguales?: {peso1==dolar1}");
            Console.WriteLine($"2° son iguales?: {peso2 == dolar1}");
            */

            /*
            //COMPARACION DE PESOS VS EUROS
            Pesos peso1 = new Pesos(104);
            Pesos peso2 = new Pesos(71.28);
            Euro euro1 = new Euro(1);

            Console.WriteLine($"1° son iguales?: {peso1 == euro1}");
            Console.WriteLine($"2° son iguales?: {peso2 == euro1}");
            */

            /*
            //SUMA Y RESTA ENTRE PESOS
            Pesos peso1 = new Pesos(104);
            Pesos peso2 = new Pesos(71.28);
            Pesos pesoResultado = peso1 + peso2;
            Pesos pesoResultado2 = peso1 - peso2;

            Console.WriteLine($"Resultado suma pesos: {pesoResultado.GetCantidad():0.00}");
            Console.WriteLine($"Resultado resta pesos: {pesoResultado2.GetCantidad():0.00}");
            */

            /*
            //SUMA Y RESTA ENTRE PESOS Y DOLARES
            Pesos peso1 = new Pesos(104);
            Dolar dolar = new Dolar(1);
            Pesos pesoResultado = peso1 + dolar;
            Pesos pesoResultado2 = peso1 - dolar;

            Console.WriteLine($"Resultado suma pesos y dolares: {pesoResultado.GetCantidad():0.00}");
            Console.WriteLine($"Resultado resta pesos y dolares: {pesoResultado2.GetCantidad():0.00}");
            */

            //SUMA Y RESTA ENTRE PESOS Y EUROS
            Pesos peso1 = new Pesos(104);
            Euro euro = new Euro(1);
            Pesos pesoResultado = peso1 + euro;
            Pesos pesoResultado2 = peso1 - euro;

            Console.WriteLine($"Resultado suma pesos: {pesoResultado.GetCantidad():0.00}");
            Console.WriteLine($"Resultado resta pesos: {pesoResultado2.GetCantidad():0.00}");

            Console.ReadKey();
        }
    }
}
