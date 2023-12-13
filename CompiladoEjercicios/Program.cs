using System;
using CompiladoEjercicios;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("            MENÚ DE EJERCICIOS");
            Console.WriteLine("===============================================");
            Console.WriteLine(" 1. Ejercicio 1 - Variables y Operadores");
            Console.WriteLine(" 2. Ejercicio 2 - Estructuras de Control");
            Console.WriteLine(" 3. Ejercicio 3 - Clases y Herencia");
            Console.WriteLine(" 0. Salir");
            Console.WriteLine("===============================================");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    Console.ReadLine(); // Pause after exercise 1
                    break;
                case "2":
                    Ejercicio2();
                    Console.ReadLine(); // Pause after exercise 2
                    break;
                case "3":
                    Ejercicio3();
                    Console.ReadLine(); // Pause after exercise 3
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.ReadLine(); // Pause after invalid option
                    break;
            }
        }
    }

    static void Ejercicio1()
    {
        Console.Clear();
        Console.WriteLine("Ejercicio 1 - Variables y Operadores");

        int numero1 = 550;
        int numero2 = 450;

        int resultado = numero1 + numero2;

        Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);


    }

    static void Ejercicio2()
    {
        Console.Clear();
        Console.WriteLine("Ejercicio 2 - Estructuras de Control");


        int edad = 25;
        if (edad >= 18)
        {
            Console.WriteLine("La persona es mayor de edad, tiene {0} años.", edad);
        }
        else
        {
            Console.WriteLine("La persona no es mayor de edad, tiene {0} años.", edad);
        }
    }

    static void Ejercicio3()
    {
        Console.Clear();
        Console.WriteLine("Ejercicio 3 - Clases y Herencia");

        EstudianteGraduado estudiante1 = new EstudianteGraduado();
        estudiante1.Nombre = "Mateo Condor";
        estudiante1.Edad = 20;
        estudiante1.Calificacion = 20;
        estudiante1.Titulo = "Ingeniero de Sistemas";

        estudiante1.MostrarInformacion();
    }
}

