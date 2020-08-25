using System;
using System.Collections.Generic;

namespace TP_N_3
{
    class GestionCursos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CURSOS 2020 UTN FACULTAD REGIONAL SAN FRANCISCO");

            while (true)
            {
                var finalizado = DesarrolloCursos();

                if (finalizado) break;

            }
        }

        static public bool DesarrolloCursos()
        {
            while (true)
            {
                Console.WriteLine("\n 1) Registrar participante \n 2) Registrar nuevo curso \n 3) Mostrar cursos \n 4) Mostrar inscriptos \n 5) Mostrar inscripciones emitidas");
                Console.WriteLine("\nOPCION ");
                var Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Sujeto.RegistroSujeto();
                        break;

                    case 2:
                        Curso.RegistroCurso();
                        break;

                    case 3:
                        Curso.MostrarCursos();
                        break;

                    case 4:
                        Sujeto.MostrarSujetos();
                        break;

                    case 5:
                        Inscripcion.MostrarInscripciones();
                        break;

                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }

                Console.Clear();
                Console.WriteLine("\nDesea seguir navegando?   \n1- Sí \n2- No");
                var opcionElegidaSeguir = int.Parse(Console.ReadLine());
                Console.Clear();

                if (opcionElegidaSeguir == 1) return false;

                else return true;
            }
        }

        class Curso
        {
            public static List<Curso> Cursos = new List<Curso>();
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public string Horario { get; set; }
            public string Aula { get; set; }
            public double CupoMAx { get; set; }
            public double CupoMin { get; set; }

            public Curso(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string horario, string aula, double cupomax, double cupomin)
            {
                Nombre = nombre;
                Descripcion = descripcion;
                FechaInicio = fechaInicio;
                FechaFin = fechaFin;
                Horario = horario;
                Aula = aula;
                CupoMAx = cupomax;
                CupoMin = cupomin;
            }

            static public void RegistroCurso()
            {
                Console.WriteLine("REGISTRO CURSOS");

                Console.WriteLine("Ingrese el nombre del curso: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese a quién va destinado el curso: ");
                string descripcion = Console.ReadLine();

                Console.WriteLine("Ingrese fecha inicio del curso: ");
                DateTime fechaInicio = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese fecha fin del curso: ");
                DateTime fechaFin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese horario del curso: ");
                string horario = Console.ReadLine();

                Console.WriteLine("Ingrese aula a dictarse: ");
                string aula = Console.ReadLine();

                Console.WriteLine("Ingrese cupo mínimo de estudiantes: ");
                double cupomax = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cupo máximo de estudiantes: ");
                double cupomin = double.Parse(Console.ReadLine());

            }

            static public void MostrarCursos()
            {
                Console.WriteLine("\n\n LISTADO CURSOS DISPONIBLES: ");
                int pos = 1;
                foreach (var cursos in Cursos)
                {
                    Console.WriteLine("\n Nombre: " + cursos.Nombre);
                    Console.WriteLine("\n Destinado a: " + cursos.Descripcion);
                    Console.WriteLine("\n Fecha Inicio curso: " + cursos.FechaInicio);
                    Console.WriteLine("\n Fecha Fin curso: " + cursos.FechaFin);
                    Console.WriteLine("\n Horarios: " + cursos.Horario);
                    Console.WriteLine("\n Aula a dictarse: " + cursos.Aula);
                    Console.WriteLine("\n Minimo de anotados requerido: " + cursos.CupoMin);
                    Console.WriteLine("\n Cupo maximo de anotados: " + cursos.CupoMAx);
                    Console.WriteLine("-------------------------------------------------");

                    pos++;
                }

                Console.WriteLine("\n\n");
                RegistroDocente.MostrarDocentes();
            }
        }

        class Docente
        {
            public string NombreD { get; set; }
            public string DNID { get; set; }
            public string EmailD { get; set; }
            public string TelefonoD { get; set; }
            public string EspecialidadD { get; set; }

            public Docente(string nombre, string dni, string email, string telefono, string especialidadD)
            {
                NombreD = nombre;
                DNID = dni;
                EmailD = email;
                TelefonoD = telefono;
                EspecialidadD = especialidadD;
            }
        }

        public class RegistroDocente
        {
            static List<Docente> Docentes = new List<Docente>();

            static RegistroDocente()
            {
                Docentes.Add(new Docente("Gabriela Nuñez", "20158147", "ganuñez@gmail.com", "3564895287", "Ing. Qumica"));
                Docentes.Add(new Docente("Roberto Lorri", "18158177", "relorri@gmail.com", "3564414748", "Ing. en Sistemas"));
                Docentes.Add(new Docente("Daniel Osvaldo", "30698657", "osvaldodani@gmail.com", "3564203132", "Ing. Electronica"));
                Docentes.Add(new Docente("Luisa Keller", "27548741", "lukeller@gmail.com", "3564895287", "Ing. Electromecanica"));
                Docentes.Add(new Docente("Ana Carra", "21212147", "acarra@gmail.com", "3565663248", "Ing. Industrial"));
            }

            static public void MostrarDocentes()
            {
                Console.WriteLine("\n\n DOCENTES DISPONIBLES:");
                int pos = 1;

                foreach (var docentes in Docentes)
                {
                    Console.WriteLine(pos + "-" + docentes.NombreD + "\t" + docentes.DNID + "\t" + docentes.EmailD + "\t" + docentes.TelefonoD + "\t" + docentes.EspecialidadD);
                    pos++;
                }
            }

        }

        class Sujeto
        {
            public static List<Sujeto> Sujetos = new List<Sujeto>();
            public string Nombre { get; set; }
            public string DNI { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

            public Sujeto(string nombre, string dni, string email, string telefono)
            {
                Nombre = nombre;
                DNI = dni;
                Email = email;
                Telefono = telefono;
            }

            static public void RegistroSujeto()
            {
                Console.WriteLine("\n\n REGISTRO INTERESADOS");

                Console.WriteLine("\nIngrese nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("\nIngrese DNI: ");
                string dni = Console.ReadLine();

                Console.WriteLine("\nIngrese email de contacto: ");
                string email = Console.ReadLine();

                Console.WriteLine("\nIngrese telefono de contacto: ");
                string telefono = Console.ReadLine();
            }

            static public void MostrarSujetos()
            {
                Console.WriteLine("\n\n INTERESADOS INSCRIPTOS:");
                int pos = 1;

                foreach (var sujetos in Sujetos)
                {
                    Console.WriteLine(pos + "-" + "Nombre/Apellido: " + sujetos.Nombre + "Email contacto: " + sujetos.Email);
                    Console.WriteLine("--------------------------");
                    pos++;
                }
            }
        }

        class Inscripcion
        {
            public static List<Inscripcion> Inscripciones = new List<Inscripcion>();
            public DateTime FechaInscripcion { get; set; }
            public Curso Curso { get; set; }
            public Sujeto Sujeto { get; set; }

            public Inscripcion(Sujeto sujeto, DateTime fechainscripcion, Curso curso)
            {
                Sujeto = sujeto;
                FechaInscripcion = fechainscripcion;
                Curso = curso;
            }

            static public void MostrarInscripciones()
            {
                Console.WriteLine("\n INSCRIPCIONES HASTA LA FECHA ");

                foreach (var inscripciones in Inscripciones)
                {
                    Console.WriteLine("\n Fecha inscripcion: " + inscripciones.FechaInscripcion);
                    Console.WriteLine("\n Nombre del curso: " + inscripciones.Curso.Nombre);
                    Console.WriteLine("\n Fecha inicio del curso: " + inscripciones.Curso.FechaInicio);
                    Console.WriteLine("\n Nombre persona postulante: " + inscripciones.Sujeto.Nombre);
                    Console.WriteLine("\n Telefono de contacto postulante: " + inscripciones.Sujeto.Telefono);

                }
            }
        }
    }
}

