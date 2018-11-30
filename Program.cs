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
            Printer.WriteTitle("Control de escuelas");
            EscuelaEngine escuelaEngine = new EscuelaEngine();

            Printer.Beep(1500, repeticiones:3);
            ImprimirCursos(escuelaEngine.Escuela);
        }
        private static void ImprimirCursos(Escuela escuela){
            if(escuela!= null && escuela.Cursos != null){
                foreach (var curso in escuela.Cursos)
                {
                    System.Console.WriteLine(curso);
                }
            }
        }
    }
}
