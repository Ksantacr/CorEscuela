using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Escuela = new Escuela("La salle", 2019);
            Escuela.TipoEscuela = TipoEscuelas.Primaria;
            InicializarCursos();

        }

        private void InicializarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso{Nombre = "101"},
                new Curso{Nombre = "102",Jornada = TiposJornadas.Vespertina },
                new Curso{Nombre = "103" }
            };
        }
    }
}