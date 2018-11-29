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

            Curso c1 = new Curso{
                Nombre = "101"
            };
            Curso c2 = new Curso{
                Nombre = "102",
                Jornada = TiposJornadas.Vespertina
            };
            Curso c3 = new Curso{
                Nombre = "103"
            };

            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);
            System.Console.WriteLine(c3);
        }
    }
}
