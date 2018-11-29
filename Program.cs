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

            System.Console.WriteLine(escuela);

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso{
                Nombre = "101"
            };
            Curso c2 = new Curso{
                Nombre = "102",
                Jornada = TiposJornadas.Vespertina
            };
            arregloCursos[1] = c2;
            Curso c3 = new Curso{
                Nombre = "103"
            };
            arregloCursos[2] = c3;

            ImprimirCursos(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int item = 0;
            while(item < arregloCursos.Length) {
                System.Console.WriteLine(arregloCursos[item]);
                item++;
            }
        }
    }
}
