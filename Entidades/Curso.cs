using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public enum TiposJornadas {
        Matutina,
        Vespertina
    }
    public class Curso
    {
        public Curso(string uniqueID, string nombre, TiposJornadas jornada) 
        {
            this.UniqueID = uniqueID;
                this.Nombre = nombre;
                this.Jornada = jornada;
               
        }
                public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TiposJornadas Jornada { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Curso(TiposJornadas jornada = TiposJornadas.Matutina) => (UniqueID,  Jornada, Asignaturas, Alumnos) = (UniqueID = Guid.NewGuid().ToString(), jornada, new List<Asignatura>(), new List<Alumno>());

        public override string ToString(){
            return $"UniqueID: {UniqueID}, Nombre: {Nombre}, Jornada: {Jornada}";
        }
    }
}