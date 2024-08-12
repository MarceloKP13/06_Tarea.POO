using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _06_Tarea.POO.Grupo;

namespace _06_Tarea.POO
{
    public class Gestion
    {
        private Grupo grupo;

        public Gestion()
        {
            grupo = new Grupo();
        }

        public void Iniciar()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Eliminar alumno");
                Console.WriteLine("3. Consultar nota y calificación");
                Console.WriteLine("4. Mostrar todos los alumnos");
                Console.WriteLine("5. Mostrar alumnos suspensos");
                Console.WriteLine("6. Mostrar alumnos aprobados");
                Console.WriteLine("7. Mostrar candidatos a MH");
                Console.WriteLine("8. Salir");
                Console.Write("Opción:");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("DNI: ");
                        string dni = Console.ReadLine();
                        Console.Write("Apellidos: ");
                        string apellidos = Console.ReadLine();
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Nota: ");
                        double nota = double.Parse(Console.ReadLine());

                        grupo.AgregarAlumno(dni, apellidos, nombre, nota);
                        break;

                    case "2":
                        grupo.MostrarTodosLosAlumnos();
                        Console.Write("Ingrese el DNI del alumno a eliminar: ");
                        dni = Console.ReadLine();
                        grupo.EliminarAlumno(dni);
                        break;

                    case "3":
                        Console.Write("Ingrese el DNI del alumno: ");
                        dni = Console.ReadLine();
                        grupo.ConsultarNotaCalificacion(dni);
                        break;

                    case "4":
                        grupo.MostrarTodosLosAlumnos();
                        break;

                    case "5":
                        grupo.MostrarAlumnosSuspensos();
                        break;

                    case "6":
                        grupo.MostrarAlumnosAprobados();
                        break;

                    case "7":
                        grupo.MostrarCandidatosMH();
                        break;

                    case "8":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}