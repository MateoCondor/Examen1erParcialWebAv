using System;

namespace CompiladoEjercicios
{
    public class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Titulo: " + Titulo);
        }
    }
}
