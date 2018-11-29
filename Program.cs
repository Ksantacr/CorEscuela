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
        }
    }
}
