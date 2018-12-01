using System;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

namespace CorEscuela
{
    class Program
    {

        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Control Escuelas");
            Printer.Beep(10000, repeticiones:3);
            ImpimirCursosEscuela(engine.Escuela);
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            
            Printer.WriteTitle("Cursos de la Escuela");
            
            
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueID}");
                }
            }
        }
    }
}
