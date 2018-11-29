using System;

namespace CoreEscuela.Entidades
{
    public enum TiposJornadas {
        Matutina,
        Vespertina
    }
    public class Curso
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TiposJornadas Jornada { get; set; }

        public Curso(TiposJornadas jornada = TiposJornadas.Matutina) => (UniqueID,  Jornada) = (UniqueID = Guid.NewGuid().ToString(), jornada);

        public override string ToString(){
            return $"UniqueID: {UniqueID}, Nombre: {Nombre}, Jornada: {Jornada}";
        }
    }
}