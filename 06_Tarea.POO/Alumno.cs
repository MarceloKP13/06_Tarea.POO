using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Tarea.POO
{
    public class Alumno
    {
        public string DNI { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public string Calificacion { get; private set; }

        public Alumno(string dni, string apellidos, string nombre, double nota)
        {
            DNI = dni;
            Apellidos = apellidos;
            Nombre = nombre;
            Nota = nota;
            Calificacion = CalcularCalificacion(nota);
        }

        public void ModificarNota(double nuevaNota)
        {
            Nota = nuevaNota;
            Calificacion = CalcularCalificacion(nuevaNota);
        }

        private string CalcularCalificacion(double nota)
        {
            if (nota < 5)
                return "SS";
            else if (nota >= 5 && nota < 7)
                return "AP";
            else if (nota >= 7 && nota < 9)
                return "NT";
            else
                return "SB";
        }

        public override string ToString()
        {
            return $"{DNI} {Apellidos}, {Nombre} {Nota} {Calificacion}";
        }
    }
}

