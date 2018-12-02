using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public enum TiposJornadas {
        Matutina,
        Vespertina
    }
    public class Curso : ObjetoEscuelaBase
    {
        public Curso(string uniqueID, string nombre, TiposJornadas jornada) 
        {
            this.Nombre = nombre;
            this.Jornada = jornada;
               
        }
        public TiposJornadas Jornada { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Curso(TiposJornadas jornada = TiposJornadas.Matutina) => (Jornada, Asignaturas, Alumnos) = (jornada, new List<Asignatura>(), new List<Alumno>());

        public override string ToString(){
            return $"UniqueID: {UniqueId}, Nombre: {Nombre}, Jornada: {Jornada}";
        }
    }
}