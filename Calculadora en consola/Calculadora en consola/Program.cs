using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_en_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mantenerMenu = true;

            while (mantenerMenu)
            {
                // Menú
                Console.WriteLine("\nCalculadora:");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicación");
                Console.WriteLine("4 - División");
                Console.WriteLine("5 - Elevar un número a la potencia");
                Console.WriteLine("6 - Salir");
                Console.Write("\n\nSeleccione una opción: ");

                // Recoger opcion de usuario
                int opcion = int.Parse(Console.ReadLine());

                // Tipos de datos Double por si el usuario coloca una cantidad muy grande
                double num1, num2, resultado;

                // Opciones 
                switch (opcion)
                {
                    // ******** SUMA *************
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    // ******** RESTA *************
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    // ******** MULTIPLICACION *************
                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    // ******** DIVISION *************
                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                            Console.ReadKey();
                        }
                        break;

                    // ******** pOTENCIA *************
                    case 5:
                        Console.Write("Ingrese la base: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el exponente: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"\nResultado: {num1} ^ {num2} = {resultado}");
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    // ******** OPCION SALIR *************
                    case 6:
                        Console.WriteLine("Adios");
                        mantenerMenu = false;
                        break;

                    // ******** POR SI EL USUARIO SE PONE GREATIVO *************
                    default:
                        Console.WriteLine("\nLa opcion que estas digitando no existe. Por favor, seleccione una opción del menú (No se ponga creativo;).\n\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;


                }
            }
        }
    }
}
