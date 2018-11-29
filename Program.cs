using System;
using CoreEscuela.Entidades;
namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de escuelas");

            Escuela escuela = new Escuela("La salle", 2019);
            escuela.TipoEscuela = TipoEscuelas.Primaria;

            Console.WriteLine(escuela);

            escuela.Cursos = new Curso[]{
                new Curso{Nombre = "101"},
                new Curso{Nombre = "102",Jornada = TiposJornadas.Vespertina },
                new Curso{Nombre = "103" }
            };

            ImprimirCursos(escuela);
            Operadores();
        }

        private static void Operadores(){
            Console.WriteLine("Documentación: https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/");
        }
        private static void ImprimirCursos(Escuela escuela){
            if(escuela!= null && escuela.Cursos != null){
                foreach (var curso in escuela.Cursos)
                {
                    System.Console.WriteLine(curso);
                }
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int item = 0;
            while(item < arregloCursos.Length) {
                Console.WriteLine(arregloCursos[item]);
                item++;
            }
        }
    }
}
