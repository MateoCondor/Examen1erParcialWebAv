using System;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del estudiante:");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Calificación: " + Calificacion);
    }
}

class EstudianteGraduado : Estudiante
{
    public string Titulo { get; set; }

    public void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Titulo: " + Titulo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        EstudianteGraduado estudiante1 = new EstudianteGraduado();
        estudiante1.Nombre = "Mateo Condor";
        estudiante1.Edad = 20;
        estudiante1.Calificacion = 20;
        estudiante1.Titulo = "Ingeniero de Sistemas";

        estudiante1.MostrarInformacion();
    }
}
