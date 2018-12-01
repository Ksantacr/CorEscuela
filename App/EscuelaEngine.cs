using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academay", 2012, TiposEscuela.Primaria,
            ciudad: "Bogotá", pais: "Colombia"
            );

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    foreach (var asignatura in curso.Asignaturas)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            asignatura.Evaluaciones.Add(new Evaluaciones {
                            Alumno = alumno, Asignatura = asignatura, Nota = (float)Math.Round(GenerarNota(), 2, MidpointRounding.ToEven), Nombre = GenerarNombre(asignatura.Nombre, alumno.Nombre)
                            }); 
                        }
                    }
                }
            }
        }
        private string GenerarNombre(string asignatura, string alumno) {
            DateTime fecha = DateTime.Now;
            return $"{asignatura.ToUpper()}_{alumno}_{fecha.ToLongDateString()}";
        }

        private double GenerarNota() {
            Random rnd = new Random();
            return rnd.NextDouble() * 5;
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas"} ,
                            new Asignatura{Nombre="Educación Física"},
                            new Asignatura{Nombre="Castellano"},
                            new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar( int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornadas.Matutina },
                        new Curso() {Nombre = "201", Jornada = TiposJornadas.Matutina},
                        new Curso{Nombre = "301", Jornada = TiposJornadas.Matutina},
                        new Curso(){ Nombre = "401", Jornada = TiposJornadas.Matutina },
                        new Curso() {Nombre = "501", Jornada = TiposJornadas.Matutina},
            };
            
            Random rnd = new Random();
            foreach(var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}