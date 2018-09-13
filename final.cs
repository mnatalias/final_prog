using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de función EJERCICIO 1
            char [] arreglo1 = { 'a', 'b', 'c' };
            char [] arreglo2 = { 'b', 'c' };

            int iguales = IgualesVector(arreglo1, arreglo2);
            Console.WriteLine(iguales);

            // Uso de función EJERCICIO 2
            string [,] matrizNombres = { { "Laura", "Matias" },
                                         { "Maria", "Juan" } };

            MuestraNombres(matrizNombres);
        }


        // Definir la función EJERCICIO 1 - Compara arreglos
        static bool IgualesVector (char[] arr1, char[] arr2)
        {
            if (arr1.Length == arr2.Length) // comparo la longitud de los arreglos
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                        return 0; // si los caracteres son diferentes devuelvo cero.
                }
                return trrue; // si recorro los dos arreglos y los caracteres son iguales devuelvo true;
            }

            return false; // Devuelvo false si la longitud de los dos arreglos es diferente.
        }

        // Definir la función EJERCICIO 2

        static bool MuestraNombres(string[,] matriz)
        {
            int fila = 0;
            int col = 0;

            do
            {
                Console.WriteLine("Ingrese número de fila");
                fila = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese número de columna");
                col = int.Parse(Console.ReadLine());

                if ((fila >= 0) & (col >= 0)) // si no ingreso fila o col negativa muestro el nombre
                {
                    if ( fila >= matriz.GetLength(0) | col >= matriz.GetLength(1) ) // si ingreso una fila o col fuera de la matriz salgo de la funcion devolviendo false
                    {
                        return false;
                    }
                    else
                    {
                        string nombre = matriz[fila, col];
                        Console.WriteLine("El nombre en la posición {0}, {1} es {3}", fila, col, nombre);
                        return true;
                    }

                }
                else
                    return true; // salgo de la función devolviendo true si ingresó fila o col negativo.
            } while ((fila >= 0) & (col >= 0)); // el bucle se sigue ejecutando si la fila y columna ingresadas son positivos
        }
    }
}
