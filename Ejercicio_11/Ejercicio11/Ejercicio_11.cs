using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 11";

            int valorMin = -100;
            int valorMax = 100;
            int cantIntentos = 5;
            int contador = 0;
            int flag = 0;
            int numMax = 0;
            int numMin = 0;
            int acumulador = 0;
            float promedio;


            while (contador < cantIntentos)
            {
                Console.Write($"Por favor, ingrese un numero del {valorMin} al {valorMax}: ");

                if(int.TryParse(Console.ReadLine(), out int valorIngresado))
                {
                    if (Validacion.Validar(valorIngresado, valorMin, valorMax))
                    {
                        contador++;
                        acumulador += valorIngresado;
                        if(flag == 0)
                        {
                            flag = 1;
                            numMax = valorIngresado;
                            numMin = valorIngresado;
                        }
                        else
                        {
                            if(valorIngresado > numMax)
                            {
                                numMax = valorIngresado;
                            }
                            else if (valorIngresado < numMin)
                            {
                                numMin = valorIngresado;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número no se encuentra dentro del rango permitido.");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }

            promedio = acumulador / (float)cantIntentos;

            Console.WriteLine($"El valor maximo es: {numMax}");
            Console.WriteLine($"El valor minimo es: {numMin}");
            Console.WriteLine($"El promedio de los valores es: {promedio:0.00}");
            Console.ReadKey();
        }
    }
}

/*
          int contador = 0;
            int numIngr;
            int numMin = 0;
            int numMax = 0;
            int acumulador = 0;
            int valorMaximo = 100;
            int valorMinimo = -100;
            Console.WriteLine("Por favor, ingrese 10 numeros: ");
            while (contador < 5)
            {
                numIngr = int.Parse(Console.ReadLine());
                //if()
                if (contador == 0)
                {
                    numMax = numIngr;
                    numMin = numIngr;
                }
                else
                {
                    if (numIngr > numMax)
                    {
                        numMax = numIngr;
                    }
                    else if (numIngr < numMin)
                    {
                        numMin = numIngr;
                    }
                }
                acumulador += numIngr;
                contador++;
   }*/
