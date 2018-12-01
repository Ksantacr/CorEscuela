using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluaciones> Evaluaciones { get; set; } = new List<Evaluaciones>();

        public Asignatura(string nombre="") => (UniqueId, Nombre) = (Guid.NewGuid().ToString(), nombre);
    }
}