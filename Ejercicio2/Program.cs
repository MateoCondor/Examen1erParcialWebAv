using System;

class Program
{
    static void Main()
    {
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
}

