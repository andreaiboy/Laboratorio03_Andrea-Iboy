using System;

namespace ConversorNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Mostrar el menú al usuario
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Tarea laboratorio 8 - Andrea Gabriela Iboy Casados - 1076623");
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Seleccionar una opción:");
                Console.WriteLine("1. Convertir un numero a binario");
                Console.WriteLine("2. Convertir un numero a hexadecimal");
                Console.WriteLine("3. Salir");

                // Leer la opción seleccionada por el usuario
                Console.Write("Opción ");
                string opcion = Console.ReadLine();

                // Verificar la opción seleccionada por el usuario
                if (opcion == "1")
                {
                    // Pedir al usuario que ingrese el número en base 10
                    Console.Write("Ingresar un número en base 10: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    // Convertir el número en base 10 a su equivalente en binario
                    string binario = Convert.ToString(numero, 2);

                    // Mostrar el número ingresado por el usuario y su equivalente en binario en pantalla
                    Console.WriteLine("{0} en binario es {1}", numero, binario);
                }
                else if (opcion == "2")
                {
                    // Pedir al usuario que ingrese el número en base 10
                    Console.Write("Ingresar un número en base 10: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    // Convertir el número en base 10 a su equivalente en hexadecimal
                    string hexadecimal = Convert.ToString(numero, 16);

                    // Mostrar el número ingresado por el usuario y su equivalente en hexadecimal en pantalla
                    Console.WriteLine("{0} en hexadecimal es {1}", numero, hexadecimal);
                }
                else if (opcion == "3")
                {
                    // Salir del programa
                    break;
                }
                else
                {
                    // Opción inválida
                    Console.WriteLine("Invalido, intentalo de nuevo. Ingrese un numero del menu.");
                }

                Console.WriteLine();
            }
        }
    }
}