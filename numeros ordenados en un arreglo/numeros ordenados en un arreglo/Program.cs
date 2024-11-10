using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_ordenados_en_un_arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            // bucle para que cuente hasta diez y recoga diez numeros
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingresa el número para la posición {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Ordenamos los numeros del arreglo
            Array.Sort(numeros);

            Console.WriteLine("\nLos números ingresados son:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
        }
    }
}
