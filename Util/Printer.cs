using System;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño) {
            Console.WriteLine("".PadLeft(tamaño, '='));
        }
        public static void WriteTitle(string titulo) {
            DibujarLinea(titulo.Length);
            System.Console.WriteLine(titulo);
            DibujarLinea(titulo.Length);
        }
        public static void Beep(int hz= 1000, int duracion = 500, int repeticiones = 1) {
            while(repeticiones-- > 0) {
                Console.Beep(hz, duracion);
            }
        }
    }
}