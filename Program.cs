using System;
using System.IO;
using System.Reflection;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mi calculadora básica";
            Console.ForegroundColor = ConsoleColor.Green;

            int num1;
            int num2;
            int resultado;
            int opcion;
            int condicion;

        INICIO:
            Console.Clear();
            Console.WriteLine("Seleccione el numero de opción que corresponde a la operación que desea realizar:\n");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir\n");

            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion <= 5){

                Console.WriteLine("Ahora Capture los numeros:\n");
                Console.WriteLine("Primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                // INICIO OPERACIONES
                switch (opcion) {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + resultado);
                        Console.WriteLine("¿Desea realizar otra operación?.\n Presione 1 para Si o 0 para No.\n"); 
                        condicion = Convert.ToInt32(Console.ReadLine());

                        if (condicion == 1)
                        {
                            goto INICIO;
                        }
                        else if (condicion == 0)
                        {
                            Environment.Exit(0);
                        }
                            break;
                           
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resultado);
                        Console.WriteLine("¿Desea realizar otra operación?.\n Presione 1 para Si o 0 para No.\n");
                        condicion = Convert.ToInt32(Console.ReadLine());

                        if (condicion == 1)
                        {
                            goto INICIO;
                        }
                        else if (condicion == 0)
                        {
                            Environment.Exit(0);
                        }
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicación entre " + num1 + " y " + num2 + " es: " + resultado);
                        Console.WriteLine("¿Desea realizar otra operación?.\n Presione 1 para Si o 0 para No.\n");
                        condicion = Convert.ToInt32(Console.ReadLine());

                        if (condicion == 1)
                        {
                            goto INICIO;
                        }
                        else if (condicion == 0)
                        {
                            Environment.Exit(0);
                        }
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la división entre " + num1 + " y " + num2 + " es: " + resultado);
                        Console.WriteLine("¿Desea realizar otra operación?.\n Presione 1 para Si o 0 para No.\n");
                        condicion = Convert.ToInt32(Console.ReadLine());

                        if (condicion == 1)
                        {
                            goto INICIO;
                        }
                        else if (condicion == 0)
                        {
                            Environment.Exit(0);
                        }
                        break;
                } // FIN SWITCH
            }
            Console.WriteLine("Seleccione una opción válida.\nPresione cualquier tecla para volver a intentar.");
            Console.ReadLine();
            goto INICIO;

        }
    }
}
