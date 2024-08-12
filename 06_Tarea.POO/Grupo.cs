using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Tarea.POO
{
    public class Grupo
    {
        private List<Alumno> alumnos;

        public Grupo()
        {
            alumnos = new List<Alumno>
            {
                new Alumno("33245", "García Pérez", "Carlos", 7.8),
                new Alumno("128676", "Romero Rodríguez", "Luisa", 9)
            };
        }

        public void AgregarAlumno(string dni, string apellidos, string nombre, double nota)
        {
            if (alumnos.Any(alumno => alumno.DNI == dni))
            {
                Console.WriteLine($"Ya existe un alumno con el DNI {dni}.");
            }
            else
            {
                alumnos.Add(new Alumno(dni, apellidos, nombre, nota));
                Console.WriteLine("\t |Alumno agregado exitosamente |");
            }
        }

        public void MostrarTodosLosAlumnos()
        {
            if (alumnos.Count > 0)
            {
                Console.WriteLine("Lista de alumnos:");
                foreach (var alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos registrados.");
            }
        }

        public void EliminarAlumno(string dni)
        {
            Alumno alumnoAEliminar = alumnos.Find(a => a.DNI == dni);
            if (alumnoAEliminar != null)
            {
                alumnos.Remove(alumnoAEliminar);
                Console.WriteLine($"\t |Alumno con DNI {dni} ha sido eliminado |");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún alumno con el DNI {dni}.");
            }
        }

        public void ConsultarNotaCalificacion(string dni)
        {
            Alumno alumno = alumnos.Find(a => a.DNI == dni);
            if (alumno != null)
            {
                Console.WriteLine($"\t |Nota: {alumno.Nota}");
                Console.WriteLine($"\t |Calificación: {alumno.Calificacion}");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún alumno con el DNI {dni}.");
            }
        }

        public void MostrarAlumnosSuspensos()
        {
            var suspensos = alumnos.Where(a => a.Nota < 5).ToList();
            if (suspensos.Count > 0)
            {
                Console.WriteLine("Alumnos suspensos:");
                foreach (var alumno in suspensos)
                {
                    Console.WriteLine(alumno);
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos suspensos.");
            }
        }

        public void MostrarAlumnosAprobados()
        {
            var aprobados = alumnos.Where(a => a.Nota >= 5 && a.Nota < 10).ToList();
            if (aprobados.Count > 0)
            {
                Console.WriteLine("Alumnos aprobados:");
                foreach (var alumno in aprobados)
                {
                    Console.WriteLine(alumno);
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos aprobados.");
            }
        }

        public void MostrarCandidatosMH()
        {
            var candidatosMH = alumnos.Where(a => a.Nota == 10).ToList();
            if (candidatosMH.Count > 0)
            {
                Console.WriteLine("Candidatos a Matrícula de Honor:");
                foreach (var alumno in candidatosMH)
                {
                    Console.WriteLine(alumno);
                }
            }
            else
            {
                Console.WriteLine("No hay candidatos a Matrícula de Honor.");
            }
        }
    }
}