using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public int AñoFundacion { get; set; }
        public string Ciudad { get; set; }
        public string País { get; set; }
        public TipoEscuelas TipoEscuela { get; set; }

        /* Escuela(string nombre, int añoFundacion) {
            this.Nombre = nombre;
            this.AñoFundacion = añoFundacion;
        }*/

        public List<Curso> Cursos { get; set; }
        public Escuela(string nombre, int añoFundacion, string pais = "Ecuador", string ciudad="Guayaquil") => (Nombre, AñoFundacion, País, Ciudad) = (nombre, añoFundacion, pais, ciudad);

        public override string ToString() {
            return $"Datos escuela: \nNombre: {this.Nombre}\nAño Fundacion: {this.AñoFundacion}\nTipo Escuela: {this.TipoEscuela} {System.Environment.NewLine}País: {this.País}\nCiudad: {this.Ciudad}";
        }
    }
}